using CustomCastings;

AlphabetLetter letter = new('g');

Console.WriteLine("Using explicit casting");
char c = (char)letter;
Console.WriteLine(c);

Console.WriteLine("Using implicit casting");
AlphabetLetter otherLetter = 'a';
Console.WriteLine(otherLetter.Character);