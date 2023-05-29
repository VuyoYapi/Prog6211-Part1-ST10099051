using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;
using System.Collections;
using System.Collections.Generic;

namespace Assignment_1_POE
{
    public delegate void MyDelegate(string msg);
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration of Variables of the original values
            int n = 1;
            int x = 2;
            int y = 3;
            double w = 0.25;
            double m = 0.5;
            //declaration of Half of the Variables
            double t = n * 0.5;
            double u = x * 0.5;
            double v = y * 0.5;
            double nal = w * 0.5;
            double mal = m * 0.5;
            //declaration of the doubled value
            int val = n * 2;
            int tex = x * 2;
            int ya = y * 2;
            double yesd = w * 2;
            double itu = m * 2;
            //declaration the tripled value
            int ouy = n * 3;
            int ouik = x * 3;
            int ouj = y * 3;
            double uyf = w * 3;
            double tuc = m * 3;

            //declartion of the Array
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            string[] steps = { "The first step is to take the braaied meat", "The second step is to take the braaied mielies", "The third step is to take the pap in a big pot", "The fourth step is to take the chakalaka and add it to dish", "The five step is to add the salad, vegetable and sweet onto the dish", "The sixth step is to add the fresh baked bread to the meal", "The seventh step is when meal is done the are some desserts you enjoy afterwards." };
            //Display Questions for the user
            Console.WriteLine("Welcome to Lindiwe's Birthday paid");
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to see the names of the ingredients in the Recipe?");
            String name = Console.ReadLine();


            Console.WriteLine(" ");
            Console.WriteLine("The recipe for the ingredients is: ");
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine("- " + ingredients[i]);
            }
            Console.WriteLine(" ");
            //display the number of ingredients
            Console.WriteLine("The number of ingredients is: " + ingredients.Length);
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to see the quantities of the ingredients");
            string name1 = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("The quanitities of the ingredients are:");
            Console.WriteLine(ingredients[0] + " is " + n + " leg of chicken");
            Console.WriteLine(ingredients[1] + " is " + x + " pieces of beef ");
            Console.WriteLine(ingredients[2] + " is " + n + " leg of lamb");
            Console.WriteLine(ingredients[3] + " is " + n + " roasted of mielies");
            Console.WriteLine(ingredients[4] + " is " + x + " spoons of pap");
            Console.WriteLine(ingredients[5] + " is " + n + "  spoon of pap");
            Console.WriteLine(ingredients[6] + " is " + y + " spoons of salad");
            Console.WriteLine(ingredients[7] + " is " + n + " hand of roasted vegetables");
            Console.WriteLine(ingredients[8] + " is " + y + " three sweet potatoes");
            Console.WriteLine(ingredients[9] + " is " + n + " fresh loaf of breed");
            Console.WriteLine(ingredients[10] + " is " + w + " cup of pudding");
            Console.WriteLine(ingredients[11] + " is " + w + " a cup of mustard ");
            Console.WriteLine(ingredients[12] + " is " + m + " a cup of Chocolate ice-cream ");
            Console.WriteLine("");
            //display the 7 steps
            Console.WriteLine("Press enter to see the steps for making the recipe:");
            string name2 = Console.ReadLine();
            for (int j = 0; j < steps.Length; j++)
            {
                Console.WriteLine("- " + steps[j]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to see the number of steps");
            string name5 = Console.ReadLine();
            Console.WriteLine("There are:" + steps.Length + "steps");
            Console.WriteLine(" ");
            //display full recipe
            Console.WriteLine("Press enter to Display the full Recipe");
            string name4 = Console.ReadLine();
            Console.WriteLine("The ingredients are: ");
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine("- " + ingredients[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("The number of ingredients is: " + ingredients.Length);
            Console.WriteLine(" ");
            Console.WriteLine("The quantities of the ingredients");
            Console.WriteLine(" ");
            Console.WriteLine("The quanitities of the ingredients are:");
            Console.WriteLine("- " + ingredients[0] + " is " + n + " leg of chicken");
            Console.WriteLine("- " + ingredients[1] + " is " + x + " two pieces of beef ");
            Console.WriteLine("- " + ingredients[2] + " is " + n + " leg of lamb");
            Console.WriteLine("- " + ingredients[3] + " is " + n + " roasted of mielies");
            Console.WriteLine("- " + ingredients[4] + " is " + x + " two spoons of pap");
            Console.WriteLine("- " + ingredients[5] + " is " + n + "  spoon of pap");
            Console.WriteLine("- " + ingredients[6] + " is " + y + " 3 spoons of salad");
            Console.WriteLine("- " + ingredients[7] + " is " + n + " hand of roasted vegetables");
            Console.WriteLine("- " + ingredients[8] + " is " + y + " three sweet potatoes");
            Console.WriteLine("- " + ingredients[9] + " is " + n + " fresh loaf of breed");
            Console.WriteLine("- " + ingredients[10] + " is " + w + " cup of pudding");
            Console.WriteLine("- " + ingredients[11] + " is " + w + " a cup of mustard ");
            Console.WriteLine("- " + ingredients[12] + " is " + m + " a cup of Chocolate ice-cream ");
            Console.WriteLine("");
            Console.WriteLine("The 7 steps for making the recipe:");
            Console.WriteLine(" ");
            Console.WriteLine("- The first step is to take the braaied meat");
            Console.WriteLine("- The second step is to take the braaied mielies");
            Console.WriteLine("- The third step is to take the pap in a big pot");
            Console.WriteLine("- The fourth step is to take the chakalaka and add it to dish");
            Console.WriteLine("- The five step is to add the salad, vegetable and sweet onto the dish");
            Console.WriteLine("- The sixth step is to add the fresh baked bread to the meal");
            Console.WriteLine("- The seventh step is when meal is done the are some desserts you enjoy afterwards.");
            Console.WriteLine(" ");
            //Display the scaled version
            int choice;
            Console.WriteLine("This is the calcucation of the different values");
            Console.WriteLine("You have three options to Scaled to the quantitive value of the ingredient");
            Console.WriteLine("Press 1 to half the value" + "\nPress 2 to double the value" + "\nPress 3 to triple the value");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(ingredients[0] + " is " + t + " leg of chicken");
                    Console.WriteLine(ingredients[1] + " is " + u + " pieces of beef ");
                    Console.WriteLine(ingredients[2] + " is " + t + " leg of lamb");
                    Console.WriteLine(ingredients[3] + " is " + t + " roasted of mielies");
                    Console.WriteLine(ingredients[4] + " is " + u + " two spoons of pap");
                    Console.WriteLine(ingredients[5] + " is " + t + "  spoon of pap");
                    Console.WriteLine(ingredients[6] + " is " + v + " 3 spoons of salad");
                    Console.WriteLine(ingredients[7] + " is " + t + " hand of roasted vegetables");
                    Console.WriteLine(ingredients[8] + " is " + v + " three sweet potatoes");
                    Console.WriteLine(ingredients[9] + " is " + t + " fresh loaf of breed");
                    Console.WriteLine(ingredients[10] + " is " + nal + " cup of pudding");
                    Console.WriteLine(ingredients[11] + " is " + nal + " a cup of mustard ");
                    Console.WriteLine(ingredients[12] + " is " + mal + " a cup of Chocolate ice-cream ");
                    Console.WriteLine("The Values have Halved");
                    break;
                case 2:
                    Console.WriteLine(ingredients[0] + " is " + val + " leg of chicken");
                    Console.WriteLine(ingredients[1] + " is " + tex + "  pieces of beef ");
                    Console.WriteLine(ingredients[2] + " is " + val + " leg of lamb");
                    Console.WriteLine(ingredients[3] + " is " + val + " roasted of mielies");
                    Console.WriteLine(ingredients[4] + " is " + tex + " two spoons of pap");
                    Console.WriteLine(ingredients[5] + " is " + val + "  spoon of pap");
                    Console.WriteLine(ingredients[6] + " is " + ya + " spoons of salad");
                    Console.WriteLine(ingredients[7] + " is " + val + " hand of roasted vegetables");
                    Console.WriteLine(ingredients[8] + " is " + ya + " three sweet potatoes");
                    Console.WriteLine(ingredients[9] + " is " + val + " fresh loaf of breed");
                    Console.WriteLine(ingredients[10] + " is " + yesd + " cup of pudding");
                    Console.WriteLine(ingredients[11] + " is " + yesd + " a cup of mustard ");
                    Console.WriteLine(ingredients[12] + " is " + itu + " a cup of Chocolate ice-cream ");
                    Console.WriteLine("The values have Doubled");
                    break;
                case 3:
                    Console.WriteLine(ingredients[0] + " is " + ouy + " leg of chicken");
                    Console.WriteLine(ingredients[1] + " is " + ouik + " two pieces of beef ");
                    Console.WriteLine(ingredients[2] + " is " + ouy + " leg of lamb");
                    Console.WriteLine(ingredients[3] + " is " + ouy + " roasted of mielies");
                    Console.WriteLine(ingredients[4] + " is " + ouik + " two spoons of pap");
                    Console.WriteLine(ingredients[5] + " is " + ouy + "  spoon of pap");
                    Console.WriteLine(ingredients[6] + " is " + ouj + " 3 spoons of salad");
                    Console.WriteLine(ingredients[7] + " is " + ouy + " hand of roasted vegetables");
                    Console.WriteLine(ingredients[8] + " is " + ouj + " three sweet potatoes");
                    Console.WriteLine(ingredients[9] + " is " + ouy + " fresh loaf of breed");
                    Console.WriteLine(ingredients[10] + " is " + uyf + " cup of pudding");
                    Console.WriteLine(ingredients[11] + " is " + uyf + " a cup of mustard ");
                    Console.WriteLine(ingredients[12] + " is " + tuc + " a cup of Chocolate ice-cream ");
                    Console.WriteLine("The Values have Tripled");
                    break;
                default:
                    Console.WriteLine("incorrect press only Press only 1, 2, or 3");
                    break;
            }

            {
                //Display all scaled quantities in detail and reset the values

                recieveOrignalData();
                resetMethod();
                //Part2 functions
                newvaluerecipe();
                GeneranicMethod();
                CalculatingMethod();
                MyDelegate del = ClassA.MethodA;
                del("You have Exceed 300 calories");

                Console.WriteLine("Press enter to end press");
                string name26 = Console.ReadLine();
                Console.WriteLine("Thank you for your time");

            }



            Console.ReadKey();
        }
        public static void recieveOrignalData()
        {
            //set the values to the Original values
            int n = 1;
            int x = 2;
            int y = 3;
            double w = 0.25;
            double m = 0.5;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("Press enter to return Original Values");
            string name = Console.ReadLine();
            Console.WriteLine("The quanitities of the ingredients are:");
            Console.WriteLine(ingredients[0] + " is " + n + " leg of chicken");
            Console.WriteLine(ingredients[1] + " is " + x + " pieces of beef ");
            Console.WriteLine(ingredients[2] + " is " + n + " leg of lamb");
            Console.WriteLine(ingredients[3] + " is " + n + " roasted of mielies");
            Console.WriteLine(ingredients[4] + " is " + x + " spoons of pap");
            Console.WriteLine(ingredients[5] + " is " + n + "  spoon of pap");
            Console.WriteLine(ingredients[6] + " is " + y + " spoons of salad");
            Console.WriteLine(ingredients[7] + " is " + n + " hand of roasted vegetables");
            Console.WriteLine(ingredients[8] + " is " + y + " three sweet potatoes");
            Console.WriteLine(ingredients[9] + " is " + n + " fresh loaf of breed");
            Console.WriteLine(ingredients[10] + " is " + w + " cup of pudding");
            Console.WriteLine(ingredients[11] + " is " + w + " a cup of mustard ");
            Console.WriteLine(ingredients[12] + " is " + m + " a cup of Chocolate ice-cream ");
            Console.WriteLine("");

        }
        public static void resetMethod()
        {
            //reseting the values and typing new recipe
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("Press enter to reset the value");
            string name = Console.ReadLine();
            Console.WriteLine("The original Array:");
            foreach (string i in ingredients)
            {
                Console.WriteLine(i);
            }
            Array.Clear(ingredients, 0, ingredients.Length);
            Console.WriteLine("The new values:");
            foreach (string i in ingredients)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Write the new recipe ingredients");
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();
            string name4 = Console.ReadLine();
            string name5 = Console.ReadLine();
            string name6 = Console.ReadLine();
            string name7 = Console.ReadLine();
            string name8 = Console.ReadLine();
            string name9 = Console.ReadLine();
            string name10 = Console.ReadLine();
            string name11 = Console.ReadLine();
            string name12 = Console.ReadLine();
            string name13 = Console.ReadLine();
            Console.WriteLine("Press enter to see ingredients of the new recipe");
            string name14 = Console.ReadLine();
            Console.WriteLine("first ingredient is: " + name1);
            Console.WriteLine("second ingredient is: " + name2);
            Console.WriteLine("third ingredient is: " + name3);
            Console.WriteLine("fourth ingredient is: " + name4);
            Console.WriteLine("fifth ingredient is: " + name5);
            Console.WriteLine("sixth ingredient is: " + name6);
            Console.WriteLine("seven ingredient is: " + name7);
            Console.WriteLine("eighth ingredient is: " + name8);
            Console.WriteLine("nineth ingredient is: " + name9);
            Console.WriteLine("tenth ingredient is: " + name10);
            Console.WriteLine("eleventh ingredient is: " + name11);
            Console.WriteLine("twelfth ingredient is: " + name12);
            Console.WriteLine("thirteenth ingredient is: " + name13);
        }
        public static void newvaluerecipe()
        {
            //set a new unlimited recipe
            Console.WriteLine("Here is a list of Recipes");
            Console.WriteLine("");
            Console.WriteLine("Chicken BBQ");
            Console.WriteLine("Roasted Beef ");
            Console.WriteLine("Easy fried rice");
            Console.WriteLine("Classic shepard's pie");
            Console.WriteLine("Impossible quiche");
            Console.WriteLine("Thai Beef salad");
            Console.WriteLine("Curried sausages");
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            string input = "Y";
            while (input == "Y" || input == "y" || input == "yes")
            {
                Console.WriteLine("Press enter the Recipe ");
                string name = Console.ReadLine();
                Console.WriteLine("You have chosen " + name + " recipe");
                Console.WriteLine("Do you want to choose an another recipe? Y/N");
                input = Console.ReadLine();
            }
            //Alphabetically recipes
            string[] words = { "Chicken BBQ", "Roasted Beef", "Easy fried rice", "Classic sheperd's pie", "Impossible quiche", "Thai Beef salad", "Curried sausages" };
            Array.Sort(words);
            Console.WriteLine(String.Join(", ", words));
            //recipe choose to display
            int choice;
            Console.WriteLine("Choose the recipe");
            Console.WriteLine("Press 1 for Chicken BBQ" + "\nPress 2 for Roasted Beef" + "\nPress 3 for Easy fried rice" + "\nPress 4 for Classic Sheperds" + "\nPress 5 for Impossibl quiche" + "\nPress 6 for Thai Beef salad" + "\nPress 7 for Curried sausages");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Chicken BBQ recipe");
                    break;
                case 2:
                    Console.WriteLine("Roasted Beef recipe");
                    break;
                case 3:
                    Console.WriteLine("Easy fried rice recipe");
                    break;
                case 4:
                    Console.WriteLine("Classic sheperd's pie recipe");
                    break;
                case 5:
                    Console.WriteLine("Impossible quiche recipe");
                    break;
                case 6:
                    Console.WriteLine("Thai Beef Salad recipe");
                    break;
                case 7:
                    Console.WriteLine("Curried sausages recipe");
                    break;
                default:
                    Console.WriteLine("incorrect press only Press only 1, 2, 3, 4, 5, 6, 7");
                    break;
            }
            //the number of Calories

            Console.ReadKey();
            return;

        }
        public static void GeneranicMethod()
        {
            //Generate ingredients using Generate values using generanic method
            Console.WriteLine("Here is a list of the ingredients:");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Chicken");
            dict.Add(2, "Beef");
            dict.Add(3, "Lamb");
            dict.Add(4, "Pap");
            dict.Add(5, "Mielies");
            dict.Add(6, "Sauce");
            dict.Add(7, "Rosted Vegetable");
            dict.Add(8, "Bread");
            dict.Add(9, "Pudding");
            dict.Add(10, "Custard");
            dict.Add(11, "Ice-Cream");


            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            //the number of calorieries each food contains
            Console.WriteLine("Write down what ingredients you what?");
            string name = Console.ReadLine();
            Console.WriteLine("Write the number of calories:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The ingredient you have chosen is " + name);
            Console.WriteLine("The amount of calories are " + number + " Calories");
            Console.WriteLine("");
            Console.WriteLine("Here is a list of groups");
            Dictionary<int, string> food = new Dictionary<int, string>();
            food.Add(1, "Protein");
            food.Add(2, "Grain");
            food.Add(3, "Vegetables");
            food.Add(4, "Grain");
            food.Add(5, "Dairy");

            foreach (KeyValuePair<int, string> kvp in food)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            Console.WriteLine("Press enter to continue");
            string name1 = Console.ReadLine();
            //To see Groups and the ingredients
            int choice;
            Console.WriteLine("Press 1 to see Protein" + "\nPress 2 to Grain" + "\nPress 3 to see Vegetable" + "\nPress 4 to see Dairy");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Protein:");
                    Console.WriteLine("Chicken");
                    Console.WriteLine("Beef");
                    Console.WriteLine("lamb");
                    break;
                case 2:
                    Console.WriteLine("Grain:");
                    Console.WriteLine("Pap");
                    Console.WriteLine("Mielies");
                    Console.WriteLine("Bread");
                    break;
                case 3:
                    Console.WriteLine("Vegetable:");
                    Console.WriteLine("Suace");
                    Console.WriteLine("Roasted Vegetables");
                    break;
                case 4:
                    Console.WriteLine("Dairy:");
                    Console.WriteLine("Pudding");
                    Console.WriteLine("Custard");
                    Console.WriteLine("Ice-Cream");
                    break;

                default:
                    Console.WriteLine("incorrect press only Press only 1, 2, 3, 4");
                    break;

            }

        }
        public static void CalculatingMethod()
        {
            Console.WriteLine("Write the Number of Calories of Chicken");
            int chicken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Beef");
            int beef = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of lamb");
            int lamb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of pap");
            int pap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Mielies");
            int mielie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Chakalaka sauce");
            int sauce = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Roasted vegetable");
            int vege = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of bread");
            int bread = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Pudding");
            int pudding = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Custard");
            int custard = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Ice-Cream");
            int cream = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chicken is " + chicken + " calories");
            Console.WriteLine("Beef is " + beef + " calories");
            Console.WriteLine("Lamb is " + lamb + " calories");
            Console.WriteLine("Pap is " + pap + " calories");
            Console.WriteLine("Mielies is " + mielie + " calories");
            Console.WriteLine("Chakalaka sauce is " + sauce + " calories");
            Console.WriteLine("Roasted Vegetable is " + vege + " calories");
            Console.WriteLine("Bread is " + bread + " calories");
            Console.WriteLine("Pudding is " + pudding + " calories");
            Console.WriteLine("Custard is " + custard + " calories");
            Console.WriteLine("Ice-Cream is " + cream + " calories");
            int sum = chicken + beef + lamb + pap + mielie + sauce + vege + bread + pudding + custard + cream;
            Console.WriteLine("total calories Equal to: " + sum + " calories");
            if (sum > 300)
            {
                Console.WriteLine("The total calories have exceed 300 calories");
            }
            else
            {
                Console.WriteLine("The total calories are within range");
            }

        }

    }
    public class ClassA
    {
        internal static void MethodA(string msg)
        {
            Console.WriteLine("Write the Number of Calories of Chicken");
            int chicken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Beef");
            int beef = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of lamb");
            int lamb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of pap");
            int pap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Mielies");
            int mielie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Chakalaka sauce");
            int sauce = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Roasted vegetable");
            int vege = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of bread");
            int bread = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Pudding");
            int pudding = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Custard");
            int custard = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Number of Calories of Ice-Cream");
            int cream = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chicken is " + chicken + " calories");
            Console.WriteLine("Beef is " + beef + " calories");
            Console.WriteLine("Lamb is " + lamb + " calories");
            Console.WriteLine("Pap is " + pap + " calories");
            Console.WriteLine("Mielies is " + mielie + " calories");
            Console.WriteLine("Chakalaka sauce is " + sauce + " calories");
            Console.WriteLine("Roasted Vegetable is " + vege + " calories");
            Console.WriteLine("Bread is " + bread + " calories");
            Console.WriteLine("Pudding is " + pudding + " calories");
            Console.WriteLine("Custard is " + custard + " calories");
            Console.WriteLine("Ice-Cream is " + cream + " calories");
            int sum = chicken + beef + lamb + pap + mielie + sauce + vege + bread + pudding + custard + cream;
            Console.WriteLine("total calories Equal to: " + sum + " calories");
            if (sum > 300)
            {
                Console.WriteLine("The total calories have exceed 300 calories");
            }
            else
            {
                Console.WriteLine("The total calories are within range");
            }
            Console.ReadKey();

        }


    }
} 
