using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace BL
{
    public class BL_Add
    {
        private DL_Add _dlAdd;

        public BL_Add()
        {
            _dlAdd = new DL_Add();
        }

        public bool AddEmployee(Employees employee)
        {
            return _dlAdd.AddEmployee(employee);
        }
    }
}
