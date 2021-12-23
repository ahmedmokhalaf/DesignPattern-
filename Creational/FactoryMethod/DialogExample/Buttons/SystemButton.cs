namespace DesignPattern.Creational.FactoryMethod.DialogExample.Buttons
{
    class SystemButton : Button
    {
        public override void Click()
        {
            Console.WriteLine("System Button Clicked");
        }

        public override string Show()
        {
            return "SHOW :  System Button";
        }
    }
}
