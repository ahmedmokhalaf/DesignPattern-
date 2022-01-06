using DesignPattern.Behavioral.ChainOfResponsibility.Order;
using DesignPattern.Behavioral.ChainOfResponsibility.Order.Exceptions;
using DesignPattern.Behavioral.ChainOfResponsibility.Order.Handlers;
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
using DesignPattern.Structural.Flyweight.GameBoard;
using DesignPattern.Structural.Proxy;
using DesignPattern.Structural.Proxy.Clients;
using Newtonsoft.Json;

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
        "~~~~~~~~~~      Composite.",
        "~~~~~~~~~~      Flyweights.",
        "Behavioral      Chain Of Responsibility."
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
        case 12: FlyweightDesignPattern(); break;
        case 13: ChainOfResponsibilityDesignPattern(); break;
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

void FlyweightDesignPattern()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\t\t\t\t ***  Structural Pattern  ***");
    Console.WriteLine("==============================================================================");
    Console.WriteLine("\t\t\t\t ***        Flyweight        ***");
    Console.ResetColor();

    GameBoard gameBoard = new GameBoard();

    GameTileBorder tileBorder1 = new GameTileBorder("Solid", "think", GameTileColor.TILE_COLOR_BLUE, "500x500", GameTileLevel.TILE_LEVEL_BEGINNER);
    GameTileBorder tileBorder3 = new GameTileBorder("Solid", "think", GameTileColor.TILE_COLOR_BLUE, "100x100", GameTileLevel.TILE_LEVEL_BEGINNER);
    GameTileBorder tileBorder5 = new GameTileBorder("Dashed", "think", GameTileColor.TILE_COLOR_BLUE, "100x100", GameTileLevel.TILE_LEVEL_EXPERT);
    GameTileBorder tileBorder6 = new GameTileBorder("Solid", "think", GameTileColor.TILE_COLOR_BLUE, "100x100", GameTileLevel.TILE_LEVEL_BEGINNER);
    GameTileBorder tileBorder7 = new GameTileBorder("Dashed", "think", GameTileColor.TILE_COLOR_BLUE, "100x100", GameTileLevel.TILE_LEVEL_BEGINNER);
    GameTileBorder tileBorder8 = new GameTileBorder("Solid", "think", GameTileColor.TILE_COLOR_BLUE, "100x100", GameTileLevel.TILE_LEVEL_BEGINNER);
    GameTileBorder tileBorder9 = new GameTileBorder("None", "think", GameTileColor.TILE_COLOR_BLUE, "100x100", GameTileLevel.TILE_LEVEL_EXPERT);
    GameTileBorder tileBorder10 = new GameTileBorder("None", "think", GameTileColor.TILE_COLOR_BLUE, "100x100", GameTileLevel.TILE_LEVEL_EXPERT);
    GameTileBorder tileBorder2 = new GameTileBorder("Dot", "think", GameTileColor.TILE_COLOR_BLUE, "200x200", GameTileLevel.TILE_LEVEL_INTERMEDIATE);
    GameTileBorder tileBorder4 = new GameTileBorder("Dot", "think", GameTileColor.TILE_COLOR_BLUE, "200x200", GameTileLevel.TILE_LEVEL_INTERMEDIATE);

    gameBoard.AddTile(tileBorder1);
    gameBoard.AddTile(tileBorder2);
    gameBoard.AddTile(tileBorder3);
    gameBoard.AddTile(tileBorder4);
    gameBoard.AddTile(tileBorder5);
    gameBoard.AddTile(tileBorder6);
    gameBoard.AddTile(tileBorder7);
    gameBoard.AddTile(tileBorder8);
    gameBoard.AddTile(tileBorder9);
    gameBoard.AddTile(tileBorder10);

    gameBoard.GetTiles().ForEach((x) => Console.WriteLine(JsonConvert.SerializeObject(x, Formatting.Indented)));
    Console.WriteLine("==============================================================================");
    Console.WriteLine($"Game Tile Create By Factory : {GameTileFactory.Tiles.Count()} \n" + JsonConvert.SerializeObject(GameTileFactory.Tiles, Formatting.Indented));

    Console.WriteLine("==============================================================================");
}

void ChainOfResponsibilityDesignPattern()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\t\t\t\t ***    Behavioral Pattern    ***");
    Console.WriteLine("==============================================================================");
    Console.WriteLine("\t\t\t\t *** Chain Of Responsibility ***");
    Console.ResetColor();

    User user = new User("USR-101", "Ahmed");
    Product product = new Product("PRD-1", "Lenovo Laptop");
    Order order = new Order(user, product, new DateOnly(2020, 07, 01));
    LoyaltyHandler loyaltyHandler = new LoyaltyHandler();
    loyaltyHandler
        .SetNextHandler(new ProductAvailabilityHandler())
        .SetNextHandler(new ShipmentHandler())
        .SetNextHandler(new OrderHandler());
   //Console.WriteLine(JsonConvert.SerializeObject(loyaltyHandler, Formatting.Indented));

    try { loyaltyHandler.Handle(order); }
    catch (NoLoyalUserException e){ Console.WriteLine(e.Message); }
    catch (NoProductAvailableException e) { Console.WriteLine(e.Message); }
    catch (NoShipmentAvailableException e) { Console.WriteLine(e.Message); }
    catch (Exception e) { Console.WriteLine(e.Message); }
    Console.WriteLine("==============================================================================");
}