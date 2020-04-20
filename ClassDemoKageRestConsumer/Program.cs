using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoKageRestConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            AWorker worker = new AWorker();
            worker.Start();


            Console.ReadLine();
        }
    }
}
