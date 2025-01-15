namespace MoreCSharpFun;

internal class PrintStuff
{
    private string language;

    public PrintStuff()
    {
        language = "EN";
        // This will default the language to EN if nothing is passed in 
    }
    
    //Constructor
    public PrintStuff(string temp)
    {
        language = temp;
    }
    public void PrintName(string n)
    {
        if (language == "EN")
        {
            System.Console.WriteLine("Hello " + n + "!");
        }

        if (language == "RU")
        {
            System.Console.WriteLine("Pryvyet " + n + "!");
        }
        
    }
}