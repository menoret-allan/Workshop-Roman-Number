namespace RomanNumber.Core
{
    public class RomanNumber
    {
        public string NumberToRoman(int number)
        {
            if (number == 1 || number <= 4)
            {
                return new string('I', number);
            }

            if (number == 5)
            {
                return "V";
            }

            return "X";
        }
    }
}
