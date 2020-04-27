using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbWorkers
{
        partial class Worker
        {
            public override string ToString()
            {
                return FirstName + " " + LastName;
            }
        }
}
