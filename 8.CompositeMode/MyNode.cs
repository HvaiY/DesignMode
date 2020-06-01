using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMode
{
    public class MyNode
    {
        public string Path { get; set; }

        public List<MyFile> MyFileList { get; set; }

        public List<MyNode> GetMyDirectoryList()
        {
            return null;
        }


    }
}
