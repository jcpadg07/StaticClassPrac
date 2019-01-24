using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassPrac
{
    class Program
    {
        public void Main(string[] args)
        {
            Rollercoaster.NumberOfRuns = 10;
            Rollercoaster.Speed();
            Rollercoaster chang = new Rollercoaster();
        }
    }
}
