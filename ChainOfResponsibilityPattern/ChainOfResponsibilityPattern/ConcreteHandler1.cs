using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(Request request)
        {

            if (request.Type == 1)
            {
                Console.WriteLine("Выполнен первый обработчик: " + request.Data);
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
