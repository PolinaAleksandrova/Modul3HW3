using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    public class Subject
    {
        public event EventHandler Handler;
        public void Notify()
        {
            if (Handler != null)
            {
                Handler(this, EventArgs.Empty);
            }
        }
    }
}
