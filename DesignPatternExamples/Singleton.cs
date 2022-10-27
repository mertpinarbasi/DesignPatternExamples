using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples
{
    public class Singleton
    {
        private static Singleton singleton = new Singleton();
        private static int count;
        private readonly string name;
        private Singleton()
        {
            count++;
            name = "Singleton" + count;
        }

        public static string GetInstance()
        {



            return singleton.name;
        }
    }
}
