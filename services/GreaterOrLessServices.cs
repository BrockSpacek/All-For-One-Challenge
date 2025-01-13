

namespace All_For_One_Challenge.services
{
    public class GreaterOrLessServices
    {
         public string acceptsTwoNumbers(string numberOne, string numberTwo)
         {

            int convertedNumber;
            int convertedNumberTwo;


               bool validInput = int.TryParse(numberOne, out convertedNumber);
               bool validInputTwo = int.TryParse(numberTwo, out convertedNumberTwo);

                if(validInput == false || validInputTwo == false)
                {
                    return "That is not a valid response, Please enter in a number!";
                }

            if(convertedNumber > convertedNumberTwo)
            {
                return $"{convertedNumber} is greater than {convertedNumberTwo}\n{convertedNumberTwo} is less than {convertedNumber}";
            }
            else if(convertedNumber < convertedNumberTwo)
            {
                return $"{convertedNumber} is less than {convertedNumberTwo}\n{convertedNumberTwo} is greater than {convertedNumber}";
            }
            else
            {
                return $"{convertedNumber} is equal to {convertedNumberTwo}\n{convertedNumberTwo} is equal to {convertedNumber}";
            }
            
         }
    }
}