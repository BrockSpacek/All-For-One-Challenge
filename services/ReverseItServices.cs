

namespace All_For_One_Challenge.services
{
    public class ReverseItServices
    {
         public string reverseNumber(string inputNumber)
        {
            int temp;
            int remainder;
            int reverseInt = 0;
            int convertedNumber;



            bool validInput = int.TryParse(inputNumber, out convertedNumber);

            if (validInput == false)
            {
                return "That is not a valid response, Please enter in a number!";
            }

            if (convertedNumber == 0 || convertedNumber == 00 || convertedNumber == 000)
            {
                return "Must enter valid input that is not 0";

            }
            else if (convertedNumber != 0)
            {
                temp = convertedNumber;
                while (convertedNumber > 0)
                {
                    remainder = convertedNumber % 10;
                    reverseInt = reverseInt * 10 + remainder;
                    convertedNumber /= 10;
                }

                return $"{temp}\n{reverseInt}";
            }
            else
            {
                return "How did you get here! Just enter a number";
            }

        }


         public string reverseString(string password){

            string reversePassword = "";

            for (int i = password.Length - 1; i >= 0; i--)
        {
            reversePassword += password[i];

        }

        return $"{password}\n{reversePassword}";
        }
    }
}