using System.Xml.Linq;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class DeviceController : Controller
    {

        public static List<Category> _categories = new List<Category>
        {
            new Category(1, "Laptop"),
            new Category(2, "Smart Phone"),
            new Category(3, "Printer")
        };

        private Category FindCategoryById(int Id)
        {
            Category category = _categories.Find(category => category.Id == Id);
            if (category != null)
            {
                return category;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        private static List<Device> _device = new List<Device> {
            new Device(1, "Dell Laptop", "D001", _categories.Find(c => c.Id == 1), "In use", DateTime.Now),
            new Device(2, "Iphone 15", "D002",  _categories.Find(c => c.Id == 2), "Broken", DateTime.Now),
            new Device(3, "ASUS Ultimate", "D003",  _categories.Find(c => c.Id == 1), "Under maintenance", DateTime.Now),
            new Device(4, "Canon Printer", "D004",  _categories.Find(c => c.Id == 3), "Under maintenance", DateTime.Now)
        };

        private Device FindDeviceById(int Id)
        {
            Device device = _device.Find(d => d.Id == Id);
            if (device != null)
            {
                return device;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public IActionResult Index()
        {
            ViewBag.Categories = _categories;
            return View(_device);
        }

        [HttpGet]
        public IActionResult Filter(string name, string status)
        {
            var filteredDevices = _device.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(name))
            {
                filteredDevices = filteredDevices
                    .Where(d => d.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(status))
            {
                filteredDevices = filteredDevices
                    .Where(d => d.Status.Equals(status, StringComparison.OrdinalIgnoreCase));
            }

            if (filteredDevices.Count() == 0)
            {
                filteredDevices = _device;
            }
            ViewBag.Categories = _categories;
            return View("Index", filteredDevices.ToList());
        }

        [HttpGet]
        public IActionResult SearchByName(string deviceName)
        {
            if (string.IsNullOrWhiteSpace(deviceName))
            {
                return View(_device);
            }

            List<Device> filtered = _device
                .Where(d => d.Name.Contains(deviceName, StringComparison.OrdinalIgnoreCase))
                .ToList();
            return View(filtered); ;
        }

        [HttpPost]
        public IActionResult AddDevice(string name, string code, Category category, string status)
        {

            int lastId = _device.Count > 0 ? _device.Max(c => c.Id) + 1 : 0;

            Device device = new Device(lastId, name, code, category, status, DateTime.Now);
            _device.Add(device);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteUser(int deviceId)
        {
            Device device = FindDeviceById(deviceId);
            _device.Remove(device);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditDevice(Device newDevice, int categoryId)
        {
            Device device = FindDeviceById(newDevice.Id);
            device.Name = newDevice.Name;
            device.Code = newDevice.Code;
            device.Category = FindCategoryById(categoryId);
            device.Status = newDevice.Status;
            return RedirectToAction("Index");
        }
    }
}
