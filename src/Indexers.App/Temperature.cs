namespace Indexers.App
{
    public class Temperature
    {
        int[] temperatures = new int[] { 30, 32, 29, 27, 22, 15, 16, 19, 23, 25, 27, 28 };

        public int this[int month]
        {

            get
            {
                return temperatures[month - 1];
            }
            set
            {
                temperatures[month - 1] = value;
            }
        }

        public int this[string month]
        {
            get
            {
                switch (month) 
                {
                    case "january": return temperatures[0];
                    case "february": return temperatures[0];
                    case "march": return temperatures[0];
                    case "april": return temperatures[0];
                    case "may": return temperatures[0];
                    case "june": return temperatures[0];
                    case "july": return temperatures[0];
                    case "august": return temperatures[0];
                    case "september": return temperatures[0];
                    case "october": return temperatures[0];
                    case "november": return temperatures[0];
                    case "december": return temperatures[0];
                    default: return -1;
                }
            }
        }
    }
}
