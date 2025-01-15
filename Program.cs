// See https://aka.ms/new-console-template for more information

using MoreCSharpFun;

public class Program
{
    public static void Main(string[] args)
    {
        PrintStuff ps = new PrintStuff();
        
        string name = ""; // initializing the variable
        
        System.Console.WriteLine("Please enter your name:");
        name = System.Console.ReadLine(); //this is a method
        
        ps.PrintName(name); // In order to do this, you must make sure that the class you are referencing is not static
        
        //System.Console.WriteLine(PrintStuff(name)); This way is different than the above because this one requires you to call a different
        //method and then return it's output
    }


}