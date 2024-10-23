using LMS.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Interfaces
{
    public interface IBorrowable
    {
        public bool? Borrow(string name,string memberName);
        public bool? Return(string name,string membername);
    }
}
