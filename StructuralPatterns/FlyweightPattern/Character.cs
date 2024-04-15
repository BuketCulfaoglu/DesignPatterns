namespace FlyweightPattern
{
    internal class Character : ICharacter
    {
        private char _char;

        public Character(char @char)
        {
            _char = @char;
            Thread.Sleep(1000);
        }

        public void Display(int fontSize)
        {
            Console.WriteLine($"Character {_char} displayed with font size {fontSize}");
        }
    }
}
