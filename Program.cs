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
using DesignPattern.Structural.Composite.DTOs.DataModelsDTO;
using DesignPattern.Structural.Decorator;
using DesignPattern.Structural.Decorator.Decorators;
using DesignPattern.Structural.Facade.FileConverter;
using DesignPattern.Structural.Proxy;
using DesignPattern.Structural.Proxy.Clients;
using Newtonsoft.Json;
using System.Text.Json;

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
        "~~~~~~~~~~      Facade.",
        "~~~~~~~~~~      Decorator.",
        "~~~~~~~~~~      Proxy.",
        "~~~~~~~~~~      Composite."
    };
    Console.WriteLine($"Select Correct Number:\n");
    Patterns.ForEach((c) => Console.WriteLine((Patterns.IndexOf(c)) + 1 + " :  " + c.ToString()));
    var NumberDesignPattern = Console.ReadLine();
    Int32 number;
    if (int.TryParse(NumberDesignPattern, out number))
    {
        DesignPatternSitwtch(Int32.Parse(NumberDesignPattern.ToString()));
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
        case 1: FactoryDesignPattern(); break;
        case 2: BuilderDesignPattern(); break;
        case 3: ProtoTypeDesignPattern(); break;
        case 4: AbstractFactoryDesignPattern(); break;
        case 5: SingleTonDesignPattern(); break;
        case 6: AdapterDesignPattern(); break;
        case 7: BridageDesignPattern(); break;
        case 8: FacadeDesignPattern(); break;
        case 9: DecoratorDesignPattern(); break;
        case 10: ProxyDesignPattern(); break;
        case 11: CompositeDesignPattern(); break;
        default: SelectDesignPattern(); break;
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
    Console.WriteLine(grade.GetType().Name + "\t" + grade.ShowReport());
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

    Console.WriteLine("==============================================================================");
}
void DecoratorDesignPattern()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\t\t\t\t ***  Structural Pattern  ***");
    Console.WriteLine("\t\t\t\t ***        Decorator        ***");
    Console.ResetColor();

    bool SmsNotifictionEnable = true;
    bool WhatsappNotifictionEnable = true;
    INotifier notifier = new EmailNotifier("aa@a.a");
    if (SmsNotifictionEnable)
    {
        notifier = new SMSNotifierDecorator(notifier, "01000000");
    }
    if (WhatsappNotifictionEnable)
    {
        notifier = new WhatsAppNotifierDecorator(notifier, "011111111");
    }
    notifier.Notify();

    Console.WriteLine("==============================================================================");
}
void ProxyDesignPattern()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\t\t\t\t ***  Structural Pattern  ***");
    Console.WriteLine("==============================================================================");
    Console.WriteLine("\t\t\t\t ***        Proxy        ***");
    Console.ResetColor();

    Application app1 = new Application1(DateOnly.FromDateTime(DateTime.UtcNow));
    Application2 app2 = new Application2();
    string[] acl = { "APP_1", "APP_3", "APP_4" };
    RouterProxy router = new RouterProxy(RouterFactory.CreateRouter(), app1, acl);
    if (router.Resolve("http://www.google.com"))
    {
        router.Stream();
    }
    Console.WriteLine("==============================================================================");

}



void CompositeDesignPattern()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\t\t\t\t ***  Structural Pattern  ***");
    Console.WriteLine("==============================================================================");
    Console.WriteLine("\t\t\t\t ***        Composite        ***");
    Console.ResetColor();

    AddressDTO address1 = new AddressDTO("St1", "13", "0020");
    AddressDTO address2 = new AddressDTO("St2", "14", "0030");
    AddressDTO address3 = new AddressDTO("St3", "15", "0040");

    OrderOwnerDTO Ahmed_Order = new OrderOwnerDTO("Ahmed", address1);
    OrderOwnerDTO ALi_Order = new OrderOwnerDTO("Ali", address3);
    OrderOwnerDTO Mohammad_Order = new OrderOwnerDTO("Mohammad", address2);

    OrderDTO order1 = new OrderDTO(Ahmed_Order, DateTime.UtcNow, 500, 8);
    OrderDTO order2 = new OrderDTO(ALi_Order, DateTime.UtcNow, 1500, 10);
    OrderDTO order3 = new OrderDTO(Mohammad_Order, DateTime.UtcNow.AddDays(10), 400, 4);

    PurchaseBill bill = new PurchaseBill(new List<OrderDTO> { order1, order2, order3 });

    var Result = JsonConvert.SerializeObject(bill, Formatting.Indented);
    Console.WriteLine("PurchaseBill : " + Result);

    Console.WriteLine("==============================================================================");
}