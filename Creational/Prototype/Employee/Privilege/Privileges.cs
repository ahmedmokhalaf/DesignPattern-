namespace DesignPattern.Creational.Prototype.Employee.Privilege
{
    class Privileges
    {

        private List<IPrivilegeType> EmployeePrivileges;


        public Privileges(List<IPrivilegeType> employeePrivileges)
        {
            EmployeePrivileges = employeePrivileges;
        }

        public List<IPrivilegeType> SetEmployeePrivileges(IPrivilegeType employeePrivileges)
        {
            if (!GetEmployeePrivileges().Any((x) => x.GetType() == employeePrivileges.GetType()))
            {
                EmployeePrivileges.Add(employeePrivileges);
            }
            return EmployeePrivileges;
        }

        public List<IPrivilegeType> GetEmployeePrivileges() => EmployeePrivileges;

        public void AddPrivilege(IPrivilegeType privilegeType)
        {
            SetEmployeePrivileges(privilegeType);
        }
        public void clearPrivileges() => EmployeePrivileges.Clear();
    }
}
