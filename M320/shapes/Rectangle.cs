using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public class Rectangle
    {
        private string name;

        private readonly int widht = 10;
        private readonly int height = 15;

        private Color color = Color.Black;

        public string Name { 
            get { return this.name; }
            set { this.name = value; }
        }

        public Color Color
        {
            get { return this.color; }
            set { this.Color = value; }
        }

        // public Color Color { get; set}

        // readonly property (getter ohne setter)
        public int Area
        {
            get { return this.widht * this.height; }
        }

        
    }
}
