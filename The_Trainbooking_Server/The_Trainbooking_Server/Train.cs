using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Trainbooking_Server
{
    public struct Compartment  //车厢类
    {
        public string number;  //车厢号
        public string[] seatCollection;  //座位号数组

    }

    public class Train  //列车类
    {
        public int passNumber;  //经过站点数目
        public string[] passStation;  //经过站点
        public int stationOption;  //站点间车票可能数
        public string trainNumber;  //列车号
        public Ticket[] ticCollection;  //列车票数组
        public Compartment[] comCollection;  //车厢数组
        public bool enable;  //是否启用

        public Train()
        {
            passNumber = 0;
            passStation = null;
            stationOption = 0;
            trainNumber = "";
            ticCollection = null;
            comCollection = null;
            enable = false;
        }
        public Train(int pnum, string[] psta, string tnum, Ticket[] tcollec, Compartment[] ccollec, bool able)
        {
            passNumber = pnum;
            passStation = psta;
            stationOption = Cn2(passNumber);
            trainNumber = tnum;
            ticCollection = tcollec;
            comCollection = ccollec;
            enable = able;
        }

        public int Factorial(int n)  //n的阶乘
        {
            if (n == 1 || n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
        public int Cn2(int n)  //求Cn2
        {
            return Factorial(n) / (Factorial(2) * Factorial(n - 2));
        }
    }

    //class Ticket  //车票类
    //{
    //    public string startStation;  //起点站
    //    public string endStation;  //终点站
    //    public Train belong;  //所属列车
    //    public string comNumber;  //车厢号
    //    public string seatNumber;  //座位号
    //    public string startTime;  //开车时间
    //    public string endTime;  //到达时间
    //    public double price;  //价格
    //    public int number;  //票数

    //    public Ticket()
    //    {
    //        startStation = "";
    //        endStation = "";
    //        belong = null;
    //        comNumber = "";
    //        seatNumber = "";
    //        startTime = "";
    //        endTime = "";
    //        price = 0;
    //        number = 0;
    //    }
    //    public Ticket(string ssta, string esta, Train bel, string cnum, string snum, string st, string et, double p, int num)
    //    {
    //        startStation = ssta;
    //        endStation = esta;
    //        belong = bel;
    //        comNumber = cnum;
    //        seatNumber = snum;
    //        startTime = st;
    //        endTime = et;
    //        price = p;
    //        number = num;
    //    }
    //}
}
