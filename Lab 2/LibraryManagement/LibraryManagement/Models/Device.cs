namespace LibraryManagement.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Category Category { get; set; }
        public string Status { get; set; }
        public DateTime DateOfEntry { get; set; }

        public Device()
        {
        }

        public Device(int id, string name, string code, Category category, string status, DateTime dateOfEntry)
        {
            Id = id;
            Name = name;
            Code = code;
            Category = category;
            Status = status;
            DateOfEntry = dateOfEntry;
        }
    }
}
