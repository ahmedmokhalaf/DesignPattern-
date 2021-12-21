using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Prototype.Employee.Privilege.Types
{
    class WebPrivilege : IPrivilegeType
    {
        public bool Disable()
        {
            return true;
        }

        public bool Enable()
        {
            return true;
        }
    }
}
