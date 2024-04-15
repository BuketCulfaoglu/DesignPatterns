using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class File : IFileSystemComponent
    {
        private readonly int _size;

        public File(int size)
        {
            _size = size;
        }

        public int GetSize()
        {
            return _size;
        }
    }
}
