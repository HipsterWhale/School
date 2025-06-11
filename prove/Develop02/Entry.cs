using System.Net;

class Entry
{
    private string _prompt;
    private string _response;
    private DateTime _date;


    public Entry(string prompt)
    {
        _date = DateTime.Now;
        _prompt = prompt;
        Console.WriteLine($"{_prompt}");
        Console.Write("> ");
        _response = Console.ReadLine();
    }
    public string GetPrompt()
    { return _prompt; }
    public void SetPrompt(string prompt)
    {_prompt = prompt;}

    public string GetResponse()
    {return _response;}
    public void SetResponse(string response)
    {_response = response;}
    
    public DateTime GetDate()
    {return _date;}

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }
}