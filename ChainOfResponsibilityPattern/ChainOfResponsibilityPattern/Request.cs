using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class Request
    {
        public int Type {  get; private set; }
        public string Data { get; private set; }
        private Request(string data, int type)
        {
            Data = data;
            Type = type;
        }

        public static Request Create(string data, int type)
        {
            if (string.IsNullOrEmpty(data))
            {
                Console.WriteLine("Data is null");
                throw new ArgumentNullException("data");
            }
            return new Request(data, type);
        }
    }
}
