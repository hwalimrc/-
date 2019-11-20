using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Node
    {
        public string name;
        public int code;

        public Node(int code, string name)
        {
            this.name = name;
            this.code = code;
        }
    }
}