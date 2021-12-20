using DesignPattern.Creational.ComputerExample;
using DesignPattern.Creational.ComputerExample.Builders;
using DesignPattern.Creational.ComputerExample.Computer.Types;
using DesignPattern.Creational.FactoryMethod.DialogExample.Dialogs;
using Newtonsoft.Json;

Console.WriteLine("==============================================================================");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\t\t\t\t *** Design Pattern   ***");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("*** Factory Method  ***");
Console.ResetColor();
SystemDialog System = new SystemDialog();
System.CreateButton().Click();
Console.WriteLine("System Dialog \n" + System.RenderDialog());
WebDialog Web = new WebDialog();
Web.CreateButton().Click();
Console.WriteLine("Web Dialog \n" + Web.RenderDialog());
UIDialog UI= new UIDialog();
UI.CreateButton().Click();
Console.WriteLine("UI Dialog \n" + UI.RenderDialog());
Console.WriteLine("==============================================================================");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("*** Builder Method  ***");
Console.ResetColor();

Director director  = new Director(new ComputerCSBuilder());
director.makeComputer();
Console.WriteLine(director.GetDashboard());

director.changeBuilder(new ComputerXLBuilder());
director.makeComputer();
Console.WriteLine(director.GetDashboard());

