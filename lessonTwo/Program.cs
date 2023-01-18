// See https://aka.ms/new-console-template for more information

// working with methods in class 

using System;
class Program
{
    static void Main(string[] args)
    {
        int cubedNum = Cube(2);
        Console.WriteLine(cubedNum);

        sayhi();
        yourAge();
        addingTwo(1, 1);
    }

    static void sayhi()                           // Method that takes input as name and prits the name
    {
        Console.Write("what is your name? ");
        string userName = Console.ReadLine();
        Console.WriteLine(" The developer is called " + userName);
    }

    static void yourAge()                         // Method takes age as an input and prints it out 
    {
        Console.Write("What is your age? ");
        int yourAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your " + yourAge + "years of age");
    }

    static void addingTwo(int numb1, int numb2)   // Method takes two args and sums them
    {
        Console.Write("Give me your 1st number & Choice: ");
        numb1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Give me your 2nd number & Choice: ");
        numb2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(numb1 + numb2);
    }

    static int Cube(int Num)                       // Method to cube a number of given choice
    {
        int numz1 = Num * Num * Num;
        return numz1;
    }
}