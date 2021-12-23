namespace DesignPattern.Creational.FactoryMethod.DialogExample.Buttons
{
    class WebButton : Button
    {
        public override void Click()
        {
            Console.WriteLine("Web Button Clicked");
        }

        public override string Show()
        {
            return "SHOW :  Web Button";
        }
    }
}
