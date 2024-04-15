namespace FlyweightPattern
{
    internal class CharacterFactory
    {
        Dictionary<char, ICharacter> _characterMap = new Dictionary<char, ICharacter>();

        public ICharacter GetCharacter(char character)
        {
            if(!_characterMap.ContainsKey(character))
                _characterMap[character] = new Character(character);

            return _characterMap[character];
        }
    }
}
