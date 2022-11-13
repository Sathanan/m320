using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Triangle

{
    internal class Triangle
    {

        private Point center;
        public string Name { get; set }
        public Color color
        {
            get; private set;
        }
        protected Point[3] Points
        {
            get; private set;
        }
        public int CalcCircumfrence()
        {

        }




    }
}