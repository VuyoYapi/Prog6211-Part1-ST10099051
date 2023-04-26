using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace Assignment_1_POE
{
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
            int ouy = n *3;
            int ouik = x * 3;
            int ouj = y * 3;
            double uyf = w * 3;
            double tuc = m * 3;
            
            //declartion of the Array
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard","Chocalate Ice Cream" };
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
            Console.WriteLine("The number of ingredients is: "+ ingredients.Length);
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to see the quantities of the ingredients");
            string name1 = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("The quanitities of the ingredients are:");
            Console.WriteLine(ingredients[0]+ " is " + n + " leg of chicken");
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
            Console.WriteLine( "Press enter to see the steps for making the recipe:");
            string name2 = Console.ReadLine();
            for (int j = 0; j < steps.Length; j++)
            {
                Console.WriteLine("- " + steps[j]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to see the number of steps");
            string name5 = Console.ReadLine();
            Console.WriteLine("There are:"+ steps.Length + "steps");
            Console.WriteLine(" ");
            //display full recipe
            Console.WriteLine("Press enter to Display the full Recipe");
            string name4 = Console.ReadLine();
            Console.WriteLine("The ingredients are: ");
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine("- "+ ingredients[i]);
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
            Console.WriteLine("Press 1 to half the value"+ "\nPress 2 to double the value"+ "\nPress 3 to triple the value");
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
                Console.WriteLine("The values will reset to new quantitiy in detail and will reset everytime you press enter");
                Console.WriteLine("This message will repeat 17 times before you can move to the section");
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name6 = Console.ReadLine();
                ChangingMethodnHalf(n);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name10 = Console.ReadLine();
                ChangingMethodxHalf(x);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name11 = Console.ReadLine();
                ChangingMethodyHalf(y);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name12 = Console.ReadLine();
                ChangingMethodwHalf(w);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name13 = Console.ReadLine();
                ChangingMethodmHalf(m);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name14 = Console.ReadLine();
                ChangingMethodnDouble(n);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name15 = Console.ReadLine();
                ChangingMethodxDouble(x);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name16 = Console.ReadLine();
                ChangingMethodyDouble(y);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name17 = Console.ReadLine();
                ChangingMethodwDouble(w);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name18 = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name19 = Console.ReadLine();
                ChangingMethodmDouble(m);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name20 = Console.ReadLine();
                ChangingMethodnTriple(n);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name21 = Console.ReadLine();
                ChangingMethodxTriple(x);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name22 = Console.ReadLine();
                ChangingMethodyTriple(y);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name23 = Console.ReadLine();
                ChangingMethodwTriple(w);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name24 = Console.ReadLine();
                ChangingMethodmTriple(m);
                Console.WriteLine("");
                Console.WriteLine("Press enter to reset values");
                string name25 = Console.ReadLine();
                recieveOrignalData();
                resetMethod(); 

                
                Console.WriteLine("Press enter to end press");
                string name26 = Console.ReadLine();
                Console.WriteLine("Thank you for your time");

            }



            Console.ReadKey();
        }
        public static void ChangingMethodnHalf(double n) 
        {
            //declaration into new value half values
            n = 0.5;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new half n value of is: {0}", n);
            Console.WriteLine("Press enter to see values equal 1 turn into half the value is: {0}",n);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[0] + " is " + n + " leg of chicken");
            Console.WriteLine(ingredients[2] + " is " + n + " leg of lamb");
            Console.WriteLine(ingredients[3] + " is " + n + " roasted of mielies");
            Console.WriteLine(ingredients[5] + " is " + n + "  spoon of pap");
            Console.WriteLine(ingredients[7] + " is " + n + " hand of roasted vegetables");
            Console.WriteLine(ingredients[9] + " is " + n + " fresh loaf of breed");
            

        }
        public static void ChangingMethodxHalf(int x)
        {
            //declaration into new value half values
            x = 1;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new half x value of is: {0}",x);
            Console.WriteLine("Press enter to see values equal 2 turn into half the value is: {0}", x);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[1] + " is " + x + " pieces of beef ");
            Console.WriteLine(ingredients[4] + " is " + x + " spoons of pap");
        }
        public static void ChangingMethodyHalf(double y)
        {
            //declaration into new value half values
            y = 1.5;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new half y value of is: {0}", y);
            Console.WriteLine("Press enter to see values equal 3 turn into half the value is: {0}", y);
            string name = Console.ReadLine();
            Console.WriteLine("");
            
            Console.WriteLine(ingredients[6] + " is " + y + " spoons of salad");
            Console.WriteLine(ingredients[8] + " is " + y + " three sweet potatoes");
           

        }
        public static void ChangingMethodwHalf(double w)
        {
            //declaration into new value half values
            w = 0.125;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new half w value of is: {0}", w);
            Console.WriteLine("Press enter to see values equal 0.25 turn into half the value is: {0}", w);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[10] + " is " + w + " cup of pudding");
            Console.WriteLine(ingredients[11] + " is " + w + " a cup of mustard ");
        }
        public static void ChangingMethodmHalf(double m)
        {
            //declaration into new value half values
            m = 0.25;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("the new half m value of is: {0}", m);
            Console.WriteLine("Press enter to see values equal 0,5 turn into half the value is: {0}", m);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[12] + " is " + m + " a cup of Chocolate ice-cream ");
        }
        public static void ChangingMethodnDouble(int n)
        {
            //declaration into new value double values
            n = 2;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new double n value of is: {0}", n);
            Console.WriteLine("Press enter to see values equal 1 turn into double the value is: {0}", n);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[0] + " is " + n + " leg of chicken");
            Console.WriteLine(ingredients[2] + " is " + n + " leg of lamb");
            Console.WriteLine(ingredients[3] + " is " + n + " roasted of mielies");
            Console.WriteLine(ingredients[5] + " is " + n + "  spoon of pap");
            Console.WriteLine(ingredients[7] + " is " + n + " hand of roasted vegetables");
            Console.WriteLine(ingredients[9] + " is " + n + " fresh loaf of breed");
 
        }
        public static void ChangingMethodxDouble(int x)
        {
            //declaration into new value double values
            x = 4;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new double x value of is: {0}", x);
            Console.WriteLine("Press enter to see values equal 2 turn into double the value is: {0}", x);
            string name = Console.ReadLine();
            Console.WriteLine("");
             Console.WriteLine(ingredients[1] + " is " + x + " pieces of beef ");
            Console.WriteLine(ingredients[4] + " is " + x + " spoons of pap");
        
        }
        public static void ChangingMethodyDouble(int y)
        {
            //declaration into new value double values
            y = 6;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new double y value of is: {0}", y);
            Console.WriteLine("Press enter to see values equal 3 turn into double the value is: {0}", y);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[6] + " is " + y + " spoons of salad");
            Console.WriteLine(ingredients[8] + " is " + y + " three sweet potatoes");
        }
        public static void ChangingMethodwDouble(double w)
        {
            //declaration into new value double values
            w = 0.5;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new double w value of is: {0}", w);
            Console.WriteLine("Press enter to see values equal 0.25 turn into double the value is: {0}", w);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[10] + " is " + w + " cup of pudding");
            Console.WriteLine(ingredients[11] + " is " + w + " a cup of mustard ");
        }
        public static void ChangingMethodmDouble(double m)
        {
            //declaration into new value double values
            m = 1;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("the new double m value of is: {0}", m);
            Console.WriteLine("Press enter to see values equal 0.5 turn into double the value is: {0}", m);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[12] + " is " + m + " a cup of Chocolate ice-cream ");
        }
        public static void ChangingMethodnTriple(int n)
        {
            //declaration into new value triple values
            n = 3;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new triple n value of is: {0}", n);
            Console.WriteLine("Press enter to see values equal 1 turn into triple the value is: {0}", n);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[0] + " is " + n + " leg of chicken");
            Console.WriteLine(ingredients[2] + " is " + n + " leg of lamb");
            Console.WriteLine(ingredients[3] + " is " + n + " roasted of mielies");
            Console.WriteLine(ingredients[5] + " is " + n + "  spoon of pap");
            Console.WriteLine(ingredients[7] + " is " + n + " hand of roasted vegetables");
            Console.WriteLine(ingredients[9] + " is " + n + " fresh loaf of breed");
        }
        public static void ChangingMethodxTriple(int x)
        {
            //declaration into new value triple values
            x = 6;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new triple x value of is: {0}", x);
            Console.WriteLine("Press enter to see values equal 2 turn into triple the value is: {0}", x);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[1] + " is " + x + " pieces of beef ");
            Console.WriteLine(ingredients[4] + " is " + x + " spoons of pap");
        }
        public static void ChangingMethodyTriple(int y)
        {
            //declaration into new value triple values
            y = 9;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new triple y value of is: {0}", y);
            Console.WriteLine("Press enter to see values equal 3 turn into triple the value is: {0}", y);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[6] + " is " + y + " spoons of salad");
            Console.WriteLine(ingredients[8] + " is " + y + " three sweet potatoes");
        }
        public static void ChangingMethodwTriple(double w)
        {
            //declaration into new value triple values
            w = 0.75;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new triple w value of is: {0}", w);
            Console.WriteLine("Press enter to see values equal 0.25 turn into triple the value is: {0}", w);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[10] + " is " + w + " cup of pudding");
            Console.WriteLine(ingredients[11] + " is " + w + " a cup of mustard ");

        }
        public static void ChangingMethodmTriple(double m)
        {
            //declaration into new value triple values
            m = 1.5;
            string[] ingredients = { "Chicken", "Beef", "Leg of Lamb ", "A Big Pot Of Pap", "Roasted Mielies", "Chakalaka Sauce", "Salads", "Roasted Vegetable", "Sweet Potatoes", "Freshly Baked Bread", "Malva Pudding", "Custard", "Chocalate Ice Cream" };
            Console.WriteLine("The new triple m value of is: {0}", m);
            Console.WriteLine("Press enter to see values equal 0.5 turn into triple the value is: {0}", m);
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(ingredients[12] + " is " + m + " a cup of Chocolate ice-cream ");
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
            foreach(string i in ingredients)
            {
                Console.WriteLine(i);
            }
            Array.Clear(ingredients,0,ingredients.Length);
            Console.WriteLine("The new values:");
            foreach (string i in  ingredients)
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
            Console.WriteLine("Press enter to see the new recipe");
            string name14 = Console.ReadLine();
            Console.WriteLine("first ingredient is: " + name1);
            Console.WriteLine("first ingredient is: " + name2);
            Console.WriteLine("first ingredient is: " + name3);
            Console.WriteLine("first ingredient is: " + name4);
            Console.WriteLine("first ingredient is: " + name5);
            Console.WriteLine("first ingredient is: " + name6);
            Console.WriteLine("first ingredient is: " + name7);
            Console.WriteLine("first ingredient is: " + name8);
            Console.WriteLine("first ingredient is: " + name9);
            Console.WriteLine("first ingredient is: " + name10);
            Console.WriteLine("first ingredient is: " + name11);
            Console.WriteLine("first ingredient is: " + name12);
            Console.WriteLine("first ingredient is: " + name13);
        }
        

    }
} 