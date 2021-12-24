using DesignPattern.Bridge.Structural.Grades;
using DesignPattern.Bridge.Structural.Reports;
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
using DesignPattern.Creational.Singleton;
using DesignPattern.Structural.Adapter.SMSAdapter.Adapters;
using DesignPattern.Structural.Adapter.SMSAdapter.Messages;
using DesignPattern.Structural.Bridge.Reports;
using DesignPattern.Structural.Facade.FileConverter;

SelectDesignPattern();

void SelectDesignPattern()
{
    List<string> Patterns = new List<string>() {
        "Creational      Factory.",
        "~~~~~~~~~~      Builder.",
        "~~~~~~~~~~      ProtoType.",
        "~~~~~~~~~~      Abstract Factory.",
        "~~~~~~~~~~      SingleTon.",
        "Structural      Adapter.",
        "~~~~~~~~~~      Bridge.",
        "~~~~~~~~~~      Facade."
    };
    Console.WriteLine($"Select Correct Number:\n");
    Patterns.ForEach((c) => Console.WriteLine((Patterns.IndexOf(c)) + 1 + " :  "+ c.ToString()));
    ConsoleKeyInfo NumberDesignPattern = Console.ReadKey();
    Int32 number;
    if (Char.IsNumber(NumberDesignPattern.KeyChar) || Int32.TryParse(NumberDesignPattern.KeyChar.ToString(), out number))
    {
        DesignPatternSitwtch(Int32.Parse(NumberDesignPattern.KeyChar.ToString()));
    }
    else
    {
        SelectDesignPattern();
    }
}
void DesignPatternSitwtch(int key)
{
    switch (key)
    {
        case 1  : FactoryDesignPattern();         break;
        case 2  : BuilderDesignPattern();         break;
        case 3  : ProtoTypeDesignPattern();       break;
        case 4  : AbstractFactoryDesignPattern(); break;
        case 5  : SingleTonDesignPattern();       break;
        case 6  : AdapterDesignPattern();         break;
        case 7  : BridageDesignPattern();         break;
        case 8  : FacadeDesignPattern();          break;
        default : SelectDesignPattern();          break;
    }
}


void FactoryDesignPattern()
{
    Console.WriteLine("==============================================================================");
    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("\t\t\t\t *** === Design Pattern ===   ***");
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
}
void BuilderDesignPattern()
{

    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("*** Builder Method  ***"); Console.ResetColor();

    Director director = new Director(new ComputerCSBuilder());
    director.makeComputer();
    Console.WriteLine(director.GetDashboard());

    director.changeBuilder(new ComputerXLBuilder());
    director.makeComputer();
    Console.WriteLine(director.GetDashboard());
    Console.WriteLine("==============================================================================");

}
void ProtoTypeDesignPattern()
{

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
}
void AbstractFactoryDesignPattern()
{

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
}
void SingleTonDesignPattern()
{

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("*** SingleTon Method  ***");
    Console.ResetColor();

    AppSettings Settings = AppSettings.GetInstance();
    string DBConfig = AppSettings.GetConfig("Database");
    Console.WriteLine(DBConfig);
    string CacheConfig = AppSettings.GetConfig("Cache");
    Console.WriteLine(CacheConfig);

    Console.WriteLine("==============================================================================");
}
void AdapterDesignPattern()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\t\t\t\t ***  Structural Pattern  ***");
    Console.WriteLine("\t\t\t\t ***         Adapter      ***");
    Console.ResetColor();

    SMSMessage SMSMessage1 = new SMSMessage("Test Message", "010001000100");
    SMSMessage SMSMessage2 = new SMSMessage("Test Message2", "0100");
    SMSMessage SMSMessage3 = new SMSMessage("Test Message3", "22222222222");
    SMSMessage SMSMessage4 = new SMSMessage("Test Message4", "555");
    SMSMessage SMSMessage5 = new SMSMessage("Test Message5", "888");
    List<SMSMessage> SMSMessages = new List<SMSMessage>();
    SMSMessages.Add(SMSMessage1);
    SMSMessages.Add(SMSMessage2);
    SMSMessages.Add(SMSMessage3);
    SMSMessages.Add(SMSMessage4);
    SMSMessages.Add(SMSMessage5);
    ABSSMSClientAdapter? client = new ABSSMSClientAdapter(SMSMessages.Distinct().ToList());
    var x = client.filterNumbers();
    client.Send();
    Console.WriteLine(client.getDeliveryStatus());
    Console.WriteLine("==============================================================================");
}
void BridageDesignPattern()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\t\t\t\t ***  Structural Pattern  ***");
    Console.WriteLine("\t\t\t\t ***        Brigade       ***");
    Console.ResetColor();

    Grade1Report grade = new Grade1Report(new HTMLReport());
    Console.WriteLine(grade.GetType().Name +"\t" + grade.ShowReport());
    grade.SetReport(new XHTMLReport());
    Console.WriteLine(grade.GetType().Name + "\t" + grade.ShowReport());

    Grade2Report grade2 = new Grade2Report(new PlainTextReport());
    Console.WriteLine(grade2.GetType().Name + "\t" + grade2.ShowReport());
    grade2.SetReport(new XHTMLReport());
    Console.WriteLine(grade2.GetType().Name + "\t" + grade2.ShowReport());

    Console.WriteLine("==============================================================================");
}
void FacadeDesignPattern()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\t\t\t\t ***  Structural Pattern  ***");
    Console.WriteLine("\t\t\t\t ***        FACADE        ***");
    Console.ResetColor();

    FileConverterFacade fileConverter = new FileConverterFacade("Test.mp3");
    fileConverter.DoConvert();
}