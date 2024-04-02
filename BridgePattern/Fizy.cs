namespace BridgePattern
{
    internal class Fizy : IMusicApp
    {
        public string PlayMusic(Music music)
        {
            Console.WriteLine(music + " song is playing now.. on Fizy");

            return $"{music.Name} - {music.Sound}";
        }
    }
}
