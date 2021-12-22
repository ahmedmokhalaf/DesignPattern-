using DesignPattern.Creational.AbstractFactory;
using DesignPattern.Creational.AbstractFactory.FormAbstractFactory.DesktopForm;
using DesignPattern.Creational.AbstractFactory.FormAbstractFactory.MobileForm;
using DesignPattern.Creational.AbstractFactory.FormAbstractFactory.WebForm;
using DesignPattern.Creational.ComputerExample;
using DesignPattern.Creational.ComputerExample.Builders;
using DesignPattern.Creational.FactoryMethod.DialogExample.Dialogs;
using DesignPattern.Creational.Prototype.Employee;
using DesignPattern.Creational.Prototype.Employee.Privilege;
using DesignPattern.Creational.Prototype.Employee.Privilege.Types;

Console.WriteLine("==============================================================================");
Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("\t\t\t\t *** Design Pattern   ***");
Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("*** Factory Method  ***"); Console.ResetColor();

SystemDialog System = new SystemDialog();
System.CreateButton().Click();
Console.WriteLine("System Dialog \n" + System.RenderDialog());
WebDialog Web = new WebDialog();
Web.CreateButton().Click();
Console.WriteLine("Web Dialog \n" + Web.RenderDialog());
UIDialog UI = new UIDialog();
UI.CreateButton().Click();
Console.WriteLine("UI Dialog \n" + UI.RenderDialog());

Console.WriteLine("==============================================================================");
Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("*** Builder Method  ***"); Console.ResetColor();

Director director = new Director(new ComputerCSBuilder());
director.makeComputer();
Console.WriteLine(director.GetDashboard());

director.changeBuilder(new ComputerXLBuilder());
director.makeComputer();
Console.WriteLine(director.GetDashboard());

Console.WriteLine("==============================================================================");
Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("*** ProtoType Method  ***"); Console.ResetColor();

EmployeePrototype employee1 = new EmployeePrototype(
    new ProfileData(
        "Ahmed",
        31,
        new Address(
            55, 5555,
            "St name .....",
            "Cairo",
            "EG",
            13,
            0200
            ),
        "010111111111",
        "0101010101010",
        "No Account"
        ),
    new Salary(
        3400,
        (float)0.1,
        200
        ),
    new Privileges(new List<IPrivilegeType>
        {
            new WebPrivilege(),
            new ServerRoomPrivilege(),
            new NetworkPrivilege()
        })
    );
Console.WriteLine(employee1.EmployeeInformation());
EmployeePrototype Ahmed = (EmployeePrototype)employee1.Clone();
Console.WriteLine(Ahmed.EmployeeInformation());
Console.WriteLine("==============================================================================");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("*** Abstract Factory Method  ***");
Console.ResetColor();

GUIClient WebClient = new GUIClient(new WebFormFactory());
Console.WriteLine(WebClient.CreateForm());

GUIClient MobClient = new GUIClient(new MobileFormFactory());
Console.WriteLine(MobClient.CreateForm());

GUIClient DeskTopClient = new GUIClient(new DesktopFormFactory());
Console.WriteLine(DeskTopClient.CreateForm());
Console.WriteLine("==============================================================================");
