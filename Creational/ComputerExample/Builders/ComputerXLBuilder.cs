using DesignPattern.Creational.ComputerExample.Computer;
using DesignPattern.Creational.ComputerExample.Computer.MotherBoard;
using DesignPattern.Creational.ComputerExample.Computer.MotherBoard.MainParts;
using DesignPattern.Creational.ComputerExample.Computer.MotherBoard.SocketsType;
using DesignPattern.Creational.ComputerExample.Computer.Types;
using Monitor = DesignPattern.Creational.ComputerExample.Computer.Monitor;

namespace DesignPattern.Creational.ComputerExample.Builders
{
    class ComputerXLBuilder : Builder
    {
        public override string Dashborad()
        {
            return
               $"\n************************************************************************************\n" +
               $"Computer Type : {GetComputer().GetType().Name} \n" +
               $"CPU : {BuildMotherBoard().GetCPU().GetSpeed()} GHZ\n" +
               $"DISK : {BuildMotherBoard().GetDisk().getType()}\n" +
               $"GPU : {BuildMotherBoard().GetGPU().GetSize()} GB\n" +
               $"NetworkCard : {BuildMotherBoard().GetNetworkCard().GetCategory()}\n" +
               $"Ram : {BuildMotherBoard().GetRAM().GetSize()} GB\n" +
               $"UPS IsDuration : {BuildUPS().IsDuration()} \n" +
               $"Mouse Is with Extra Utilities : {BuildMouse().IswithExtraUtilities()} \n" +
               $"Keyboard Is with UTF8 Support : {BuildKeyboard().IsUtfSupport()} \n" +
               $"Cooling System To : {BuildCoolingSystem().IsCoolingDown()} °C\n" +
               $"*******************************************************************************\n";
        }

        public override Computer.Types.Computer GetComputer()
        {
            ComputerXL computer = new ComputerXL();
            computer.SetKeyboard(BuildKeyboard());
            computer.SetMonitor(BuildMonitor());
            computer.SetMotherBoard(BuildMotherBoard());
            computer.SetMouse(BuildMouse());
            computer.SetCS(BuildCoolingSystem());
            computer.SetUps(BuildUPS());
            return computer;
        }

        protected override CoolingSystem BuildCoolingSystem()
        {
            return new CoolingSystem(5);
        }

        protected override Keyboard BuildKeyboard()
        {
            return new Keyboard(true);
        }

        protected override Computer.Monitor BuildMonitor()
        {
            return new Monitor("1920 FHD");
        }

        protected override MotherBoard BuildMotherBoard()
        {
            CPU cpu = new CPU(8);
            RAM ram = new RAM(32);
            GPU gpu = new GPU(9);
            List<object> ListOfsockets = new List<object>()
            {
             new USB(3),
             new USB(3),
             new CType(true),
             new CType(true),
             new CType(true)
            };
            Sockets sockets = new Sockets(ListOfsockets.ToArray());
            NetworkCard networkCard = new NetworkCard(15);
            Disk disk = new Disk("2 * SSD");
            return new MotherBoard(cpu, ram, gpu, sockets, networkCard, disk);
        }

        protected override Mouse BuildMouse()
        {
            return new Mouse(true);
        }

        protected override UPS BuildUPS()
        {
            return new UPS(true);
        }
    }
}
