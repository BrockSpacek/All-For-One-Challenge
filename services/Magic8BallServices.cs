

namespace All_For_One_Challenge.services
{
    public class Magic8BallServices
    {
        public string MagicEightBall(string yesOrNoQuestion)
        {
            Random rng = new Random();
            int possibleResponse = rng.Next(1, 11);


            switch (possibleResponse)
            {
                case 1:
                    return "Yes of course!";          
                case 2:
                    return "Nah, that it not happening!";
                case 3:
                    return "There is a high probability!";  
                case 4:
                    return "Interesting... no.";
                case 5:
                    return "I just looked into the future and I can say with certainty YES!";
                case 6:
                   return  "Maybe...";
                case 7:
                    return "Hmmmm it certainly is possible.";
                case 8:
                    return "Highly unlikely.";
                case 9:
                    return "I don't think so!";
                default:
                    return "100% yes!";

            }
        }
    }
}