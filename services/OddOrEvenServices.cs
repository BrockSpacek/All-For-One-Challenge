

namespace All_For_One_Challenge.services
{
    public class OddOrEvenServices
    {
         public string oddOrEven(string enterNumber)
        {

            
            int convertedNumber;


               bool validInput = int.TryParse(enterNumber, out convertedNumber);

                if(validInput == false)
                {
                    return "That is not a valid response, Please enter in a number!";
                }
                else if(convertedNumber % 2 == 0)
                {
                    return $"{convertedNumber} is an even number.";
                }
                else
                {
                    return $"{convertedNumber} is an odd number.";
                }

        }
    }
}