namespace BridgePattern
{
    internal class Speaker : ISoundDevice
    {
        public void PlaySound(string sound)
        {
            Console.WriteLine($"{sound} sound is coming from Speakers");
        }
    }
}
