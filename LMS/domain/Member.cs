using LMS.Enum.borrowcheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domains
{
    public class Member
    {
        #region proprties
        private int _memberId { get; set; }
        public string Name { get; set; }
        private string _email { get; set; }
        public  static List<Member> newMembers=new List<Member>();
        #endregion
        #region Methods 
        #region NormalMethods
        public bool Register() {
            return true;
        
        }
        public void Borrowitem(LibraryItem libraryItem) { 
        
        
        }
        public LibraryItem ReturnItem() {

       return new LibraryItem();

        
        }
        #endregion

        #region setterMethods
        public void setMemberId(int value) { 
            _memberId = value;
        
        
        }
        public Member()
        {
            
        }
        public Member(Member[] newmember )
        {
            foreach (Member m in newmember) { 
                newMembers.Add(m);
            
            }
            
        }
        public void setEmail(string value) { 
            _email = value;
        
        }
        #endregion
        #region GetterMethods
        public int getMemberId() {
            return _memberId;
        
        
        }
        public string getEmail() {
            return _email;
        
        }

        public static Member Search(string name)
        {
            Member member = newMembers.FirstOrDefault(q => q.Name == name);
            if (member != null)
            {

                return member;
            }
            else
            {

                return null;

            }

        }
        #endregion


        #endregion

    } 
}
