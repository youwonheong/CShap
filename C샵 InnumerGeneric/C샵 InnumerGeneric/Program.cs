using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C샵_InnumerGeneric
{
    class Mylist<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;

        public Mylist()
        {
            array = new T[3];
        }
        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
        public IEnumerator<T> GetEnumerator()
        {

            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }

        public T Current //제네릭 전용
        {
            get { return array[position]; }
        }

        object IEnumerator.Current //일반
        {
            get { return array[position]; }
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length); // 결과과 참이면 true반환 결과가 거짓이라면 false를 반환
        }
        public void Reset(){
            position = -1;
        }
        public void Dispose()
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> str_list = new Mylist<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach(string str in str_list)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();

            Mylist<int> int_list = new Mylist<int>();
            for(int i =0; i < 5; i++)
            {
                int_list[i] = i;
            }
            foreach( int no in int_list)
            {
                Console.WriteLine(no); 
            }

        }
    }
}
