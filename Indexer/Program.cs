using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an instance of the SampleCollection type.
            SampleCollection<string> stringCollection = new SampleCollection<string>();
            int i = 0;
            while(true ){
                // Use [] notation on the type.
                stringCollection[0] = "Hello, World";
                System.Console.WriteLine(stringCollection[0]);
                System.Console.WriteLine(i++);
                Thread.Sleep(3000);
                Console.WriteLine();
            }
        }
    }

    class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer, which will allow client code
        // to use [] notation on the class instance itself.
        // (See code in Main below.)        
        public T this[int i]
        {
            get
            {
                // This indexer is very simple, and just returns or sets
                // the corresponding element from the internal array.
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
    }
    // This class shows how client code uses the indexer.
    // Output:
    // Hello, World.
}