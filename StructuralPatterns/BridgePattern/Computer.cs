
namespace BridgePattern
{
    internal class Computer
    {
        private readonly IMusicApp _musicApp;
        private readonly ISoundDevice _soundDevice;

        public Computer(IMusicApp musicApp, ISoundDevice soundDevice)
        {
            _musicApp = musicApp;
            _soundDevice = soundDevice;
        }

        public void PlayMusic(Music music)
        {
            string sound = _musicApp.PlayMusic(music);
            _soundDevice.PlaySound(sound);
        }
    }
}
