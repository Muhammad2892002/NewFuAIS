using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Enum.borrowcheck;

namespace LMS.Domains
{
    public class LibraryItem

    {
        #region proprties 
        public static List<Book> newListBook = new List<Book>();
        public static List<Magazine> newListMagazine = new List<Magazine>();
        public string? Author { get; set; }
        public string? Title { get; set; }
        public  Isborrowed Isborrowed { get; set; }
        private string? _ISBN { get; set; }
        public string? PublishDate { get; set; }


        #endregion
        #region Methods
        public virtual void GetDetails(string name)
        {




        }
        public  void setISBN(string value) { 
            _ISBN = value;
        
        
        }
        public string? GetISBN()
        {
            return _ISBN;


        }
        #endregion

    }
}
