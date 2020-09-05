using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_이벤트테스트
{
    delegate void EventHandler(string message);  //델리게이트
    //델리게이트 Eventhandler를 이용한 이벤트를 만들자
    class MyNotifer
    {
        public event EventHandler SomethingHappend;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if(temp!=0 && temp%3 == 0)
            {
                SomethingHappend(String.Format($"{number} : 짝"));
            }
        }
    }

    

    class Program
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifer notifer = new MyNotifer();
            notifer.SomethingHappend += new EventHandler(MyHandler);
            for(int i =1; i< 30; i++)
            {
                notifer.DoSomething(i);
            }
        }
    }
}
