using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoLibrary.DTO
{
    public class DTOObject
    {
        public DTOObject()
        {
            DateCreated = DateTime.Now;
            LastChanged = DateTime.Now;
        }

        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> LastChanged { get; set; }
    }
}
