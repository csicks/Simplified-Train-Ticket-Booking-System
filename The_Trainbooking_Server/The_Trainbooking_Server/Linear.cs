using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Trainbooking_Server
{
    public class Node<T> where T : class  //链式存储结点
    {
        T data;  //值
        Node<T> next;  //后继
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
        public Node()
        {
            Data = default(T);
            Next = null;
        }
        public Node(T x)
        {
            Data = x;
        }
        public Node(Node<T> x)
        {
            data = x.data;
            next = x.next;
        }
    }

    public class Linear<T> where T : class  //线性表链式存储结构
    {
        Node<T> head;
        int lastNumber;
        public Node<T> Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }
        public int LastNumber
        {
            get
            {
                return lastNumber;
            }
            set
            {
                lastNumber = value;
            }
        }

        public Linear(T[] list)
        {
            LastNumber = list.Length;
            Head = new Node<T>();
            Node<T> q = Head;
            for (int i = 0; i < list.Length; i++)
            {
                Node<T> li = new Node<T>(list[i]);
                if (i == 0)
                {
                    Head = li;
                    q = Head;
                }
                else
                {
                    q.Next = li;
                }
                q = li;
            }
            q.Next = null;
        }
        public Linear(Linear<T> xx)
        {
            head = new Node<T>(xx.head);
            Node<T> p = xx.Head;
            while (p.Next != null)
            {
                p = p.Next;
                head.Next = new Node<T>(p.Next);
            }

        }
        public void Print()  //显示线性表
        {
            if (Head != null)
            {
                Node<T> p = Head;
                string show = " ";
                while (p.Next != null)
                {
                    show += p.Data.ToString() + " ";
                    p = p.Next;
                }
                Console.WriteLine(show);
            }
            else
                Console.WriteLine("该线性表为空！");

        }
        public T GetValue(int n)  //获取第n位的元素
        {
            Node<T> p = Head;
            if (n <= 0 || n > LastNumber)
            {
                Console.WriteLine("你输入的数字位无效！");
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    p = p.Next;
                }
            }
            return p.Data;
        }
        public void Insert(int n, T x)  //插入x至第n位的元素后
        {
            if (n <= 0)
            {
                Console.WriteLine("你输入的数字位无效！");
            }
            else if (n > LastNumber)
            {
                Node<T> p = Head;
                Node<T> nn = new Node<T>(x);
                for (int i = 0; i < LastNumber - 1; i++)
                {
                    p = p.Next;
                }
                p.Next = nn;
                nn.Next = null;
                LastNumber += 1;
            }
            else
            {
                Node<T> p = Head;
                Node<T> nn = new Node<T>(x);
                if (n == 1)
                {
                    nn.Next = Head;
                    Head = nn;
                }
                else
                {
                    for (int i = 0; i < n - 2; i++)
                    {
                        p = p.Next;
                    }
                    nn.Next = p.Next;
                    p.Next = nn;
                }
                LastNumber += 1;
            }
        }
        public void Delete(int n)  //删除第n位元素
        {
            if (n <= 0 || n > LastNumber)
            {
                Console.WriteLine("你输入的数字位无效！");
            }
            else
            {
                Node<T> p = Head;
                if (n == 1)
                {
                    Head = p.Next;
                }
                else
                {
                    for (int i = 0; i < n - 2; i++)
                    {
                        p = p.Next;
                    }
                    p.Next = p.Next.Next;
                }
                LastNumber -= 1;
            }
        }
        public void Clear()  //清空线性表
        {
            Head = null;
            LastNumber = 0;
        }
        public void Remove(int n)  //删除n位以后的元素
        {
            if (n <= 0 || n > LastNumber)
            {
                Console.WriteLine("你输入的数字位无效！");
            }
            else
            {
                Node<T> p = Head;
                for (int i = 0; i < n - 1; i++)
                {
                    p = p.Next;
                }
                p.Next = null;
                LastNumber = n;
            }
        }
        public string GetPos(T x)  //获取x的位置
        {
            string show = "线性表中出现该数的位置为：";
            Node<T> p = Head;
            for (int i = 0; i < LastNumber; i++)
            {
                if (p.Data == x)
                {
                    show += (i + 1).ToString() + " ";
                }
                p = p.Next;
            }
            if (show == "线性表中出现该数的位置为：")
                return "线性表中不存在该数！";
            else
                return show;
        }
        public bool IsEmpty()  //判断线性表是否为空
        {
            if (LastNumber == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Linear<T> Duplicate()  //复制线性表
        {
            Linear<T> copy = new Linear<T>(this);
            return copy;
        }
        public void Replace(int n, T x)  //替换第n位的元素为x
        {
            if (n <= 0 || n > LastNumber)
            {
                Console.WriteLine("你输入的数字位无效！");
            }
            else
            {
                Node<T> p = Head;
                Node<T> nn = new Node<T>(x);
                if (n == 1)
                {
                    nn.Next = Head.Next;
                    Head = nn;
                }
                else
                {
                    for (int i = 0; i < n - 2; i++)
                    {
                        p = p.Next;
                    }
                    nn.Next = p.Next.Next;
                    p.Next = nn;
                }
            }
        }
        public Linear<T> Merge(Linear<T> add)  //拼接线性表
        {
            Linear<T> result = this;
            Node<T> p = result.Head;
            for (int i = 0; i < result.LastNumber - 1; i++)
            {
                p = p.Next;
            }
            p.Next = add.Head;
            result.LastNumber += add.LastNumber;
            return result;
        }

    }
}
