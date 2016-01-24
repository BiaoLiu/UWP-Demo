using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBI.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var enumeratorWraper = new EnumeratorWraper();

            var enumerator = enumeratorWraper.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.ReadKey();
        }
    }

    public class EnumeratorWraper
    {
        public Enumerator GetEnumerator()
        {
            return new Enumerator();
        }
    }

    public class Enumerator
    {
        private string[] array = new[] { "1", "2", "3", "4", "5" };
        private int index = -1;

        public object Current => array[index];

        public bool MoveNext()
        {
            if (++index <= array.Length)
            {
                return true;
            }

            return false;
        }
    }


}
