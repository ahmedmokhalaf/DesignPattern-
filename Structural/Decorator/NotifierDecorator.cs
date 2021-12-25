using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Decorator
{
    internal class NotifierDecorator : INotifier
    {
        protected INotifier Notifier { get; set; }
        
        public NotifierDecorator(INotifier notifier)
        {
            this.Notifier = notifier;
        }

        public void Notify()
        {
            this.Notifier.Notify();
        }
    }
}
