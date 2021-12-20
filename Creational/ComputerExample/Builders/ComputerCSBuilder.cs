using DesignPattern.Creational.ComputerExample.Computer;
using DesignPattern.Creational.ComputerExample.Computer.MotherBoard;
using DesignPattern.Creational.ComputerExample.Computer.MotherBoard.MainParts;
using DesignPattern.Creational.ComputerExample.Computer.MotherBoard.SocketsType;
using DesignPattern.Creational.ComputerExample.Computer.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monitor = DesignPattern.Creational.ComputerExample.Computer.Monitor;

namespace DesignPattern.Creational.ComputerExample.Builders
{
    class ComputerCSBuilder : Builder
    {
        public override Computer.Types.Computer GetComputer()
        {
            ComputerCS computer = new ComputerCS();
            computer.SetKeyboard(BuildKeyboard());
            computer.SetMonitor(BuildMonitor());
            computer.SetMotherBoard(BuildMotherBoard());
            computer.SetMouse(BuildMouse());
            computer.SetCS(BuildCoolingSystem());
            return computer;
        }

        protected override CoolingSystem BuildCoolingSystem()
        {
            return new CoolingSystem(10);
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
            CPU cpu = new CPU(2);
            RAM ram = new RAM(16);
            GPU gpu = new GPU(3);
            List<object> ListOfsockets = new List<object>()
            {
             new USB(2),
             new USB(3),
             new CType(true),
             new CType(true),
             new CType(true)
            };
            Sockets sockets = new Sockets(ListOfsockets.ToArray());
            NetworkCard networkCard = new NetworkCard(5);
            Disk disk = new Disk("SSD");
            return new MotherBoard(cpu, ram, gpu, sockets, networkCard, disk);
        }

        protected override Mouse BuildMouse()
        {
            return new Mouse(false);
        }

        protected override UPS BuildUPS()
        {
            return new UPS(false);
        }

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
    }
}
