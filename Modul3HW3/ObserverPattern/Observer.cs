using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    public class Observer
    {
        private int _id;
        private Subject _subject;
        public Observer(int id, Subject subject)
        {
            _id = id;
            _subject = subject;
        }

        public void Attach()
        {
            _subject.Handler += SomeAction;
        }

        public void Detach()
        {
            _subject.Handler -= SomeAction;
        }

        private void SomeAction(object sender, EventArgs args)
        {
            Console.WriteLine($"Observer with id = '{_id}' has got a notification from Subject");
        }
    }
}
