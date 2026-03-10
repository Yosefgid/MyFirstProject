namespace MyFirstProject
{
    using MyFirstLibrary;
    internal class Program
    {
        static void Main(string[] args)
        {
            MyFirstLibrary.Class1.Hello();
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.WriteLine(args[2]);
            //Console.WriteLine("Hello, my name is: Yosef");
            //Console.WriteLine("My age is: " + 28);
            Console.WriteLine("My favourite film is: Jumanji!");
            string name = "Imad";
            Console.WriteLine("My name is: " + name);
            int age = 36;
            Console.WriteLine("My age is: " + age);
        }
    }
}