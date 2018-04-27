using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Server
{
    static class Exchange  //中间变量记录
    {
        //新增列车信息
        static public string[] exArray = new string[3];  //列车号 经过站点数 经过站点
        static public bool exStatus = false;

        //新增列车车票信息
        static public int[] bnum = new int[3];
        static public string[,,] trainTickets = new string[5, 8, 5];
        static public int cCount = 0;
        static public int lCount = 0;
        static public int sCount = 0;
        static public bool ticketStatus = false;

        //列车车票信息
        static public string exTicInfo = null;
        static public Linear<string[,,]> existTickets = new Linear<string[,,]>();
    }
}
