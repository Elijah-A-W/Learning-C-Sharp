// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Understanding Conditionals");

using System;

class UnderstandConditions
{
    static void Main(string[] args)
    {

        Console.WriteLine(getSquared(2, 8));

        Console.ReadLine();
    }

    static void Drinking()
    {
        bool isThirsty = true;          //Using the true consition, the if conditoin is expected here

        if (isThirsty)
        {
            Console.WriteLine("Yes the condition thirsty is true!!!");
        }
        Console.ReadLine();
    }

    static void Eating()
    {
        bool isHungry = false;           //Using false boolean, the else condition is expected here

        if (isHungry)
        {
            Console.WriteLine("Yes they are hungry!!");
        }
        else
        {
            Console.WriteLine("No they arent Hungry");
        }
    }


    static void Appearance()
    {
        bool yourHandsome = true;
        bool yourRich = true;
        bool notRich = false;
        bool youDrive = true;
        bool yourBroke = false;
        bool yourTall = true;


        if (yourHandsome && notRich)            // Using the && operator, both conditions must be true
        {
            Console.WriteLine("You might be me married");

        }
        else
        {
            if (yourHandsome || yourRich)        // Using the nested loops 
            {
                Console.WriteLine("Chances are that your are dating!!");
            }
            else if (notRich && yourBroke)
            {
                Console.WriteLine("Your on a serious hustle");
            }
            else
            {
                Console.WriteLine("Youe must be up to something !!");
            }
        }
    }



    static void Calculator()
    {
        Console.Write("Choose any\n 1.For Addition\n 2.For subtraction\n 3.For Divition\n 4.For Multiplication \n");
        int choice = Convert.ToInt32(Console.ReadLine());


        if (choice == 1)
        {
            Console.WriteLine("We are Adding:");
            Console.Write("Enter a number greater than 5: ");
            int num1add = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number lessthan 5 : ");
            int num2add = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1add + num2add);
        }
        else if (choice == 2)
        {
            Console.WriteLine("We are Subtracting:");
            Console.Write("Enter a number greater than 5: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number lessthan 5 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is: ", (num1 - num2));
        }
        else if (choice == 3)
        {
            Console.WriteLine("We are Diving:");
            Console.Write("Enter a number greater than 5: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number lessthan 5 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is: ", (num1 / num2));
        }
        else
        {
            Console.WriteLine("We are Multiplying:");
            Console.Write("Enter a number greater than 5: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number lessthan 5 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is: ", (num1 - num2));
        }
    }

    static void carSwitch(string carName)               // Using switch statements to retunr carCost given a valid car Brand
    {
        int carCost;

        switch (carName)
        {
            case "Mercedez":
                carCost = 70000;
                break;

            case "Tesla":
                carCost = 50000;
                break;

            case "Toyota":
                carCost = 25000;
                break;

            case "Jeep":
                carCost = 35000;
                break;

            default:
                carCost = 0;
                Console.WriteLine("Please enter a valid car brand name");
                break;
        }

        Console.WriteLine("The price for the " + carName + " is $" + carCost); 
    }

    static int getSquared(int baseNum, int pwNum)
    {
        int dnNum = 1;

        for (int i = 1; i < baseNum; i++)
        {
            dnNum = dnNum * pwNum;
        }

        return dnNum;
    }


}

