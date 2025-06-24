public class BreathingActivity : Activity
{
    public BreathingActivity(string welcomeMessage, string description) : base (welcomeMessage, description)
    {
        SetDuration(0); // Default duration
    }

    public void StartBreathingSession(int duration)
    {
        SetDuration(duration);
        // Logic for starting the breathing session can be added here
    }
    

}