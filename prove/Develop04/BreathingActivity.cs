using System.Diagnostics.Metrics;
using System.Globalization;

public class BreathingActivity : Activity
{
    private int counter;
    private int _respMiliSeconds;
    public BreathingActivity(string name, string description) : base(name, description)
    {
        _respMiliSeconds = 5000;
        counter = 0;
    }


    public override void Run()
    {
        while (GetActivityTimer() < GetDuration())
        {
            Respirate($"Breath in...");
            Respirate($"Now breath out...");
        }
    }

    private void Respirate(string message)
    {
        int seconds = _respMiliSeconds / 1000;
        for (int i = seconds; i >= 1; i--)
        {
            string messageWithCount = $"{message}{i}";
            Console.Write(messageWithCount);
            Thread.Sleep(1000);
            SetActivityTimer(GetActivityTimer() + 1);
            Console.Write(new string('\b', messageWithCount.Length * 2));
            Console.Write(new string(' ', messageWithCount.Length * 2));
            Console.Write(new string('\b', messageWithCount.Length * 2));


        }
    }
}