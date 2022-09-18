using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackYourFuture.DotnetMasterclass.Types
{
    public class Poodle : Dog
    {
        public Poodle(string name, FurColor furColor) : base(name)
        {
            FurColor = furColor;
        }

        public FurColor FurColor { get; set; }




    }
}


