using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    internal class Rectangle
    {
        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        private readonly int widht = 10;
        private readonly int height = 15;

        private int lineThickness = 2;

        public int lineThickness
        {

        }


    }
}
