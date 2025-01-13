

namespace All_For_One_Challenge.services
{
    public class AddNumbersServices
    {
         public string addTwoNumbers(string num1, string num2)
        {
            int convertedNumber;
            int convertedNumberTwo;


               bool validInput = int.TryParse(num1, out convertedNumber);
               bool validInputTwo = int.TryParse(num2, out convertedNumberTwo);

                if(validInput == false || validInputTwo == false)
                {
                    return "That is not a valid response, Please enter in a number!";
                }
            return $"If you add {convertedNumber} + {convertedNumberTwo}, it will equal {convertedNumber + convertedNumberTwo}.";
        }
    }
}