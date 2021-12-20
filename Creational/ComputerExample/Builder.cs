
using DesignPattern.Creational.ComputerExample.Computer;
using DesignPattern.Creational.ComputerExample.Computer.MotherBoard;


namespace DesignPattern.Creational.ComputerExample
{
    abstract class Builder
    {
        protected Computer.Types.Computer computer;

        abstract protected MotherBoard BuildMotherBoard();
        abstract protected Keyboard BuildKeyboard();
        abstract protected Mouse BuildMouse();
        abstract protected Computer.Monitor BuildMonitor();
        abstract protected CoolingSystem BuildCoolingSystem();
        abstract protected UPS BuildUPS();

        abstract public Computer.Types.Computer GetComputer();
        abstract public string Dashborad();




    }
}
