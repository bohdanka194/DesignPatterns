using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class CalendarPrototype
    {
        public virtual CalendarPrototype Clone()
        {
            var copyOfPrototype = (CalendarPrototype)this.MemberwiseClone();
            return copyOfPrototype;
        }
    }
}
