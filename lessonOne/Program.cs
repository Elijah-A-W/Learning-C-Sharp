// See https://aka.ms/new-console-template for more information
string characterName = "Andrew";
int characterAge;
characterAge = 25;
int num1 = 2;
int num2 = 4;

//Using number 
Console.WriteLine("......NUMBERS......");
Console.WriteLine(num1 - num2);
Console.WriteLine(num1 / num2);
Console.WriteLine(Math.Min(num1, num2));     //Using a Math method  Min
Console.WriteLine(Math.Max(num1, num2));     //Using a Math method  Max
Console.WriteLine(Math.Round(3.45));         //Using a Math method  Round to round off numbers

// Using the strings
Console.WriteLine(".....STRINGS.......");
Console.WriteLine("Hello, World!");
Console.WriteLine("Here we come dotnet, am called " + characterName + " and i am " + characterAge + " years ");


// Creating a simple task to get a user feedbacka and print it out

Console.Write("What is you name: ");
string userName = Console.ReadLine();
Console.WriteLine("Hello" + userName);



// Creating a simple Calculator that adds 2 number and return the sum");
Console.WriteLine(" Addition of two whole numbers to return a sum ");

Console.Write("Write any number to add : ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Write another number to add : ");
int numb2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Your total is: " + (numb1 + numb2));


// Crearting a Madlib Game basing on Uganda my country
Console.WriteLine("Brief Madlib game about Uganda President");
string behavior, color, location;

Console.Write("What is the behaviour President of your country : ");
behavior = Console.ReadLine();

Console.Write("What is his favourate dressed color: ");
color = Console.ReadLine();

Console.Write("Where is his prefered stay home area : ");
location = Console.ReadLine();

Console.WriteLine("Presidents are " + behavior);
Console.WriteLine("they love the " + color + "color");
Console.WriteLine("and stay in " + location);

// Dealing with arrays, they help with working with the large data types 
Console.WriteLine("We are now working with arrays here");

int[] chosenNum = { 3, 33, 34, 2, 5, 55, 6, 77 };
string[] movies = new string[4];

Console.WriteLine(chosenNum[2]);  // reading the 2nd index figure in the array

// Adding new items to the empyt array of movies
movies[0] = "yes";
movies[1] = "Fall";
movies[2] = "Arise";
movies[3] = "Wuyo";

Console.WriteLine("The array of movies includes : " + movies);




