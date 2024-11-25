using ChainOfResponsibilityPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Request request = Request.Create("Data", 2);
        Handler h1 = new ConcreteHandler1();
        Handler h2 = new ConcreteHandler2();
        h1.Successor = h2;
        h1.HandleRequest(request);
    }
}
