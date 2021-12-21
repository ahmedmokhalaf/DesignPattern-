using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Prototype.Employee.Privilege
{
    interface IPrivilegeType
    {
        public bool Enable();
        public bool Disable();
    }
}
