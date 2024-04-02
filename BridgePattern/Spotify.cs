namespace BridgePattern
{
    internal class Spotify : IMusicApp
    {
        public string PlayMusic(Music music)
        {
            Console.WriteLine(music + " song is playing now.. on Spotify");

            return $"{music.Name} - {music.Sound}";
        }
    }
}
