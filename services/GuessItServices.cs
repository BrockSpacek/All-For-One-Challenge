

namespace All_For_One_Challenge.services
{
    public class GuessItServices
    {
         public string GuessItEasy(string guessNumberEasy)
        {


            Random rng = new Random();
            int easy = rng.Next(1, 11);
            int convertNum;


            bool validNum = int.TryParse(guessNumberEasy, out convertNum);

            if (validNum == false)
            {
                return "Please enter in a valid number!";
            }

            if(convertNum < 1 || convertNum > 10)
            {
                return "Please enter a number between 1-10!";
            }

            if (convertNum == easy)
            {
                return "The correct number was " + easy +"!!!";
            }
            else if (convertNum > easy)
            {

                return "Hmm that guess semes to be higher than the number! Try again!";

            }
            else
            {

                return "I need you to focus, your guess is lower than the number you are looking for.";

            }
        }

        public string GuessItMedium(string guessNumberMedium)
        {
           
            Random rng = new Random();
            int medium = rng.Next(1, 51);
            int convertNum;

            bool validNum = int.TryParse(guessNumberMedium, out convertNum);

             if (validNum == false)
            {
                return "Please enter in a valid number!";
            }

            if(convertNum < 1 || convertNum > 50)
            {
                return "Please enter a number between 1-50!";
            }



            if (convertNum == medium)
            {
                return "The correct number was " + medium +"!!!";
            }
            else if (convertNum > medium)
            {
                return "Hmm that guess semes to be higher than the number! Try again!";
            }
            else
            {
                return "I need you to focus, your guess is lower than the number you are looking for.";
            }

          
        }

        public string GuessItHard(string guessNumberHard)
        {
           
            Random rng = new Random();
            int hard = rng.Next(1, 101);
            int convertNum;

            bool validNum = int.TryParse(guessNumberHard, out convertNum);

             if (validNum == false)
            {
                return "Please enter in a valid number!";
            }

            if(convertNum < 1 || convertNum > 100)
            {
                return "Please enter a number between 1-100!";
            }



            if (convertNum == hard)
            {
                return "The correct number was " + hard +"!!!";
            }
            else if (convertNum > hard)
            {
                return "Hmm that guess semes to be higher than the number! Try again!";
            }
            else
            {
                return "I need you to focus, your guess is lower than the number you are looking for.";
            }

          
        }
    }
}