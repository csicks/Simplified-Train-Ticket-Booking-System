using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Server
{
    public class User  //用户类
    {
        public string account;  //账号
        public string passWord;  //密码
        public int priority;  //优先级
        public Ticket[] ownTicket;  //所有票数组
        public int ticketnum;
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
        public User(string at, string pw, int p, int tnum, string na, string pnum)//Ticket[] oT, 
        {
            account = at;
            passWord = pw;
            priority = p;
            ticketnum = tnum;
            ownTicket = new Ticket[5];
            name = na;
            phoneNumber = pnum;
        }
    }
}
