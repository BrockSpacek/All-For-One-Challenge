

namespace All_For_One_Challenge.services
{
    public class RestarauntPickerServices
    {
        public string RestarauntPicker(string restarauntCategory)
        {

            string[] fastFood = { "McDonald's", "Wendy's", "In-n-Out", "Five Guys", "Jack-in-the-Box", "Raising Cane's", "Carl's Jr.", "Taco Bell", "Chick-Fil-A", "Popeyes", };
            string[] dineIn = { "AppleBee's", "Chili's", "Buffalo Wild Wing", "Taco's Chapala", "Market Tavern", "Squeeze Burger", "Papapavlo's", "Smitty's Wings", "Midnight at Bernie's", "El Rancho Inn", };
            string[] surpriseMe = { "El Forestero", "Dave Wong's", "La Casita Food Truck", "The Meltdown", "The Habit", "Wingstop", "String's", "Misaki Sushi and Bar", "BJ's Restaurant and Brewhouse", "Angelina's Spaghetti House", };

            Random rng = new Random();
            int possibleRestaraunt = rng.Next(1, 11);

            string foodInput = restarauntCategory;
            string foodInputLower = foodInput.ToLower();


            if (foodInputLower == "fast food")
            {


                possibleRestaraunt = rng.Next(1, 11);


                switch (possibleRestaraunt)
                {

                    case 1:

                        return "Here is what I recommend you try: " + fastFood[0];

                    case 2:

                        return "Here is what I recommend you try: " + fastFood[1];

                    case 3:

                        return "Here is what I recommend you try: " + fastFood[2];

                    case 4:

                        return "Here is what I recommend you try: " + fastFood[3];

                    case 5:

                        return "Here is what I recommend you try: " + fastFood[4];

                    case 6:

                        return "Here is what I recommend you try: " + fastFood[5];

                    case 7:

                        return "Here is what I recommend you try: " + fastFood[6];

                    case 8:

                        return "Here is what I recommend you try: " + fastFood[7];

                    case 9:

                        return "Here is what I recommend you try: " + fastFood[8];

                    case 10:

                        return "Here is what I recommend you try: " + fastFood[9];

                    default:

                        return "Sorry, we are currently under maintenence. Contact us if you have any issues or bugs!";
                }




            }


            else if (foodInputLower == "dine in")
            {


                possibleRestaraunt = rng.Next(1, 11);


                switch (possibleRestaraunt)
                {

                    case 1:

                        return "Here is what I recommend you try: " + dineIn[0];

                    case 2:

                        return "Here is what I recommend you try: " + dineIn[1];

                    case 3:

                        return "Here is what I recommend you try: " + dineIn[2];

                    case 4:

                        return "Here is what I recommend you try: " + dineIn[3];

                    case 5:

                        return "Here is what I recommend you try: " + dineIn[4];

                    case 6:

                        return "Here is what I recommend you try: " + dineIn[5];

                    case 7:

                        return "Here is what I recommend you try: " + dineIn[6];

                    case 8:

                        return "Here is what I recommend you try: " + dineIn[7];

                    case 9:

                        return "Here is what I recommend you try: " + dineIn[8];

                    case 10:

                        return "Here is what I recommend you try: " + dineIn[9];

                    default:

                        return "Sorry, we are currently under maintenence. Contact us if you have any issues or bugs!";
                }




            }


            else if (foodInputLower == "surprise me")
            {


                possibleRestaraunt = rng.Next(1, 11);


                switch (possibleRestaraunt)
                {

                    case 1:

                        return "Here is what I recommend you try: " + surpriseMe[0];

                    case 2:

                        return "Here is what I recommend you try: " + surpriseMe[1];

                    case 3:

                        return "Here is what I recommend you try: " + surpriseMe[2];

                    case 4:

                        return "Here is what I recommend you try: " + surpriseMe[3];

                    case 5:

                        return "Here is what I recommend you try: " + surpriseMe[4];

                    case 6:

                        return "Here is what I recommend you try: " + surpriseMe[5];

                    case 7:

                        return "Here is what I recommend you try: " + surpriseMe[6];

                    case 8:

                        return "Here is what I recommend you try: " + surpriseMe[7];

                    case 9:

                        return "Here is what I recommend you try: " + surpriseMe[8];

                    case 10:

                        return "Here is what I recommend you try: " + surpriseMe[9];

                    default:

                        return "Sorry, we are currently under maintenence. Contact us if you have any issues or bugs!";

                }




            }

            else
            {
                return "I'm sorry but that is not something I am able to compute.\nPlease enter in one of the categories: Fast Food, Dine In, Or Surprise Me.";
            }

        }
    }
}