namespace Operators.App
{
    public class Fraction : IEquatable<Fraction>
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public double Result =>
            (double)Numerator / Denominator;

        public override string ToString() =>
            $"{Numerator:n2}/{Denominator:n2}";

        public static Fraction operator * (Fraction left, Fraction right) =>
            new Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator);

        public static Fraction operator * (Fraction fraction, int number) =>
            new Fraction(fraction.Numerator * number, fraction.Denominator);

        public static bool operator < (Fraction left, Fraction right) =>
            left.Result < right.Result;

        public static bool operator > (Fraction left, Fraction right) =>
            left.Result < right.Result;

        public static bool operator <= (Fraction left, Fraction right) =>
          left.Result < right.Result;

        public static bool operator >= (Fraction left, Fraction right) =>
            left.Result < right.Result;

        public static bool operator == (Fraction left, Fraction right) =>
            left.Equals(right);

        public static bool operator != (Fraction left, Fraction right) =>
           !left.Equals(right);

        public bool Equals(Fraction other) =>
            Result == other.Result;
        
        public override bool Equals(object obj)
        {
            var f = obj as Fraction;

            if(f == null) return false; 

            return Equals(f);
        }

        public override int GetHashCode() =>
            Result.GetHashCode();
    }
}
