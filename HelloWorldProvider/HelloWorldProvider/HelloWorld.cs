using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProvider
{
    /// <summary>
    /// testxcvxcv
    /// </summary>
    public class HelloWorld
    {
        public string SayHello()
        {
            return SayHello("HelloWorld");
        }


        public string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}
