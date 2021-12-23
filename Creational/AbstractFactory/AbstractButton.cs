namespace DesignPattern.Creational.AbstractFactory
{
    abstract class AbstractButton
    {
        protected string? Value { get; set; }
        //{
        //    get { return this.Value; }
        //    set { this.Value = value; }
        //}

        public abstract string OnClick();
    }
}
