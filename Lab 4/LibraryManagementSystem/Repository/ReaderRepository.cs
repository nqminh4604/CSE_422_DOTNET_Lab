using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Repository
{
    internal class ReaderRepository : IReaderRepository
    {
        private List<Reader> readers = new List<Reader>();

        public void AddReader(Reader reader) => readers.Add(reader);

        public Reader GetReaderById(int id) => readers.FirstOrDefault(r => r.Id == id);

        public List<Reader> GetReaders() => readers;
    }
}
