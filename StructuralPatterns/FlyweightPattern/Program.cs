using FlyweightPattern;

CharacterFactory characterFactory = new CharacterFactory();

// Display a large document with many 'A' characters
string document = "A very long document with many instances of 'A' A very long document with many instances of 'A'";

foreach (char c in document)
{
    ICharacter character = characterFactory.GetCharacter(c);
    character.Display(12); // Assume font size is 12
}