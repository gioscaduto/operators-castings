using CustomCastings;

AlphabetLetter letter = new('g');

Console.WriteLine("Using casting explicit");
char c = (char)letter;
Console.WriteLine(c);

Console.WriteLine("Using casting implicit");
AlphabetLetter otherLetter = 'a';
Console.WriteLine(otherLetter.Character);