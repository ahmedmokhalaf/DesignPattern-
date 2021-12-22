namespace DesignPattern.Creational.AbstractFactory
{
    abstract class AbstractTextArea
    {

        protected string Name { get; set; }
        protected string Text { get; set; }
        //{
        //    get { return Text; }
        //    set { Text= value; }
        //}
        protected AbstractTextArea(string name, string text)
        {
            Name = name;
            Text = text;
        }
        abstract public string onResize();

    }
}