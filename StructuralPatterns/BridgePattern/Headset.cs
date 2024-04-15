namespace BridgePattern
{
    internal class Headset : ISoundDevice
    {
        public void PlaySound(string sound)
        {
            Console.WriteLine($"{sound} sound is coming from Headset");
        }
    }
}
