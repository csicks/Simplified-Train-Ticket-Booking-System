using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Server
{
    public class Train  //列车类
    {
        public int passNumber;  //经过站点数目
        public string[] passStation;  //经过站点
        public int stationOption;  //站点间车票可能数
        public string trainNumber;  //列车号       
        public Ticket[,,] ticCollection;  //车厢数组
        public bool enable;  //是否启用
        public int leftNum;

        public Train()
        {
            passNumber = 0;
            passStation = null;
            stationOption = 0;
            trainNumber = "";
            ticCollection = null;
            enable = false;
            leftNum = 5 * 8 * 5;
        }
        public Train(int pnum, string[] psta, string tnum, Ticket[,,] ccollec, bool able)
        {
            passNumber = pnum;
            passStation = psta;
            stationOption = Cn2(passNumber);
            trainNumber = tnum;
            ticCollection = ccollec;
            enable = able;
            leftNum = 5 * 8 * 5;
        }

        private int Factorial(int n)  //n的阶乘
        {
            if (n == 1 || n==0)
                return 1;
            return n * Factorial(n - 1);
        }
        private int Cn2(int n)  //求Cn2
        {
            return Factorial(n) / (Factorial(2) * Factorial(n - 2));
        }
    }

    public class Ticket  //车票类
    {
        public string startStation;  //起点站
        public string endStation;  //终点站
        public Train belong;  //所属列车
        public string comNumber;  //车厢号
        public string lineNumber;   //行号
        public string seatNumber;  //座位号
        public string startTime;  //开车时间
        public string endTime;  //到达时间
        public string price;  //价格
        public bool buyed;

        public Ticket()
        {
            startStation = "";
            endStation = "";
            belong = null;
            comNumber = "";
            lineNumber = "";
            seatNumber = "";
            startTime = "";
            endTime = "";
            price = "";
            buyed = false;
        }
        public Ticket(string ssta, string esta, Train bel, string cnum, string lnum, string snum, string st, string et, string p) 
        {
            startStation = ssta;
            endStation = esta;
            belong = bel;
            comNumber = cnum;
            lineNumber = lnum;
            seatNumber = snum;
            startTime = st;
            endTime = et;
            price = p;
            buyed = false;
        }
    }
}
