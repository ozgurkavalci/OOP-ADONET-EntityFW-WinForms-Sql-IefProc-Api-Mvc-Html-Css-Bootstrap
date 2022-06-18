using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EUser
    {

        private int _UserID;
        private string _UserName;
        private string _UserPw;   
        private string _UserEmail;

        public int UserID
            { get { return _UserID; } set { _UserID = value; } }    

        public string UserName
            { get { return _UserName; } set { _UserName = value; } }

        public string UserPw
            { get { return _UserPw; } set { _UserPw = value; } }    

        public string UserMail
            { get { return _UserEmail; } set { _UserEmail = value; } }



    }
}
