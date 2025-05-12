using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Interface
{
    internal interface IReaderRepository
    {
        void AddReader(Reader reader);
        Reader GetReaderById(int id);

        List<Reader> GetReaders();
    }
}
