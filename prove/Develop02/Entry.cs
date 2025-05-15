using System.Net;

class Entry
{
    private string _prompt;
    private string _response;
    private DateTime _date = DateTime.Now;


    public string GetPrompt()
    {return _prompt;}
    public void SetPrompt(string prompt)
    {_prompt = prompt;}

    public string GetResponse()
    {return _response;}
    public void SetResponse(string response)
    {_response = response;}
    
    public DateTime GetDate()
    {return _date;}


}