using System.Text;

namespace DesignPattern.Creational.AbstractFactory
{
    abstract class AbstractWindow
    {
        protected string Size { get; set; }
        protected List<object> Components = new List<object>();

        public AbstractWindow(string size)
        {
            Size = size;
        }

        protected List<object> GetComponents()
        {
            return Components;
        }

        public void SetComponents(object Component)
        {
            this.Components.Add(Component);
        }

        abstract public string onClose();
        abstract public string onResize();

        public string wRender()
        {
            StringBuilder Component = new StringBuilder();
            Components.ToList().ForEach((x) => Component.AppendLine("\t" + x.GetType().Name));
            return $"Welcome to our GUI form {this.GetType().Name}\n Components: \n {Component}";
        }
    }
}