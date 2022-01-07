using DesignPattern.Behavioral;
using DesignPattern.Creational;
using DesignPattern.Structural;

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
        case 1:  CreationalPattern.FactoryDesignPattern(); break;
        case 2:  CreationalPattern.BuilderDesignPattern(); break;
        case 3:  CreationalPattern.ProtoTypeDesignPattern(); break;
        case 4:  CreationalPattern.AbstractFactoryDesignPattern(); break;
        case 5:  CreationalPattern.SingleTonDesignPattern(); break;

        case 6:  StructuralPattern.AdapterDesignPattern(); break;
        case 7:  StructuralPattern.BridageDesignPattern(); break;
        case 8:  StructuralPattern.FacadeDesignPattern(); break;
        case 9:  StructuralPattern.DecoratorDesignPattern(); break;
        case 10: StructuralPattern.ProxyDesignPattern(); break;
        case 11: StructuralPattern.CompositeDesignPattern(); break;
        case 12: StructuralPattern.FlyweightDesignPattern(); break;

        case 13: BehavioralPattern.ChainOfResponsibilityDesignPattern(); break;
        default: SelectDesignPattern(); break;
    }
}

