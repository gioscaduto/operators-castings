namespace CustomCastings
{
    public class AlphabetLetter
    {
        public char Character { get; private set; } 

        public AlphabetLetter(char character)
        {
            Character =  char.ToLower(character);
        }

        public static explicit operator char(AlphabetLetter alphabetLetter) =>
            alphabetLetter.Character;

        public static implicit operator AlphabetLetter (char c) =>
            new AlphabetLetter(c);
    }
}
