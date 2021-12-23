namespace DesignPattern.Creational.Prototype.Employee.Privilege.Types
{
    class ServerRoomPrivilege : IPrivilegeType
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
