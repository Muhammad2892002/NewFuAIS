using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Enum.Status;


namespace LMS.abstractions
{
    public abstract class Library

    {
        public  abstract string LibraryName();
        public abstract string LibraryAddress();

        public abstract StatusEnum AddItem();
        public abstract StatusEnum RemoveItem();
        public abstract List<string> ListItemAvailable();

    }
}
