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
        Program.TypeLine($"{_prompt}");
        Program.Type("> ");
        _response = Console.ReadLine();
    }
    public Entry(string prompt, string response)
    {
        _date = DateTime.Now;
        _prompt = prompt;
        _response = response;
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
        Program.TypeLine($"Date: {_date.ToShortDateString()}");
        Program.TypeLine($"Prompt: {_prompt}");
        Program.TypeLine($"Response: {_response}");
    }
}