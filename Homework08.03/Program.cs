namespace Homework08._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.name);
            Console.WriteLine(child.Public);
            Console.WriteLine(child.Internal);
            Console.WriteLine(child.ProtectedInternal);
            //Console.WriteLine(child.Private);
            //Console.WriteLine(child.Protected);


        }
    }
}