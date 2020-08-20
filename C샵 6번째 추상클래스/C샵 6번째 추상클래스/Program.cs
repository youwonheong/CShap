using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_6번째_추상클래스
{
    class Program
    {
        abstract class AbstarctClass
        {
            protected void PrivateMethodA()
            {
                Console.WriteLine("AbstarctBas.PrivateMethodA()");
            }
            public void PublicMethodA()
            {
                Console.WriteLine("AbstarctBas.PublicMethodA()");
            }
            //여기까지는 일반 메소드이므로 자식 클래스에 그대로 상속됨 굳이 구현하지 않아도 되고 구현하면 오버라이딩으로 덮어씌우기가 됨

            //추상메소드

            public abstract void AbstractMethodA();

        }



        class Derived : AbstarctClass
        {
          /*  public void PrivateMethodA()
            {
                Console.WriteLine("PrivateMethodA()");
            }*/

            public override void AbstractMethodA()
            {
                Console.WriteLine("Derived.AbstactMethodA()");
                PrivateMethodA();
            }

        }
        static void Main(string[] args)
        {
            //AbstarctClass obj = new AbstarctClass(); 추상클래스는 인스턴스를 생성할수 없음
            AbstarctClass obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
            // obj.PrivateMethodA(); 접근제한 protected는 자신,자식 클래스밖에 불러올수 없음 
        }
    }
}
