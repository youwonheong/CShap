using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_6번째_다중상속인터페이스
{
    interface IRunnable
    {
        void Run();

    }
    interface IFlyable
    {
        void Fly();
    }

    //다중상솓
    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }
        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar Car = new FlyingCar();
            Car.Run();
            Car.Fly();

            IRunnable runnable = Car as IRunnable; // Car 인스턴드(FlyingCar)가 IRunnable를 상속받았다면 참, 아니면 NULL
            runnable.Run();

            IFlyable flyable =  Car as IFlyable;
            flyable.Fly();
            

        }
    }
}
