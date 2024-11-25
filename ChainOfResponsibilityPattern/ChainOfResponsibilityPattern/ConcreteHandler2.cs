using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(Request request)
        {

            if (request.Type == 2)
            {
                string result = string.Concat(Enumerable.Repeat(request.Data, request.Type));
                Console.WriteLine("Выполнен второй обработчик: " + result);
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
            
        }
    }
}
