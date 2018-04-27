using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Trainbooking_Server
{
    public class User  //用户类
    {
        public string account;  //账号
        public string passWord;  //密码
        public int priority;  //优先级
        public Ticket[] ownTicket;  //所有票数组
        public string name;  //名字
        public string phoneNumber;  //电话号码

        public User()
        {
            account = "";
            passWord = "";
            priority = 0;
            ownTicket = null;
            name = "";
            phoneNumber = "";
        }
        public User(string at, string pw, int p, string na, string pnum)//Ticket[] oT, 
        {
            account = at;
            passWord = pw;
            priority = p;
            //ownTicket = oT;
            name = na;
            phoneNumber = pnum;
        }
    }
}
