using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.abstractions;
using LMS.Enum.Status;

namespace LMS.domain
{
    internal class UniversityLibraty : Library
    {
        public override StatusEnum AddItem()
        {
            throw new NotImplementedException();
        }

        public override string LibraryAddress()
        {
            throw new NotImplementedException();
        }

        public override string LibraryName()
        {
            throw new NotImplementedException();
        }

        public override List<string> ListItemAvailable()
        {
            throw new NotImplementedException();
        }

        public override StatusEnum RemoveItem()
        {
            throw new NotImplementedException();
        }
    }
}
