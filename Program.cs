using System;

//start main//
string userInput = "";  // priming read
while(userInput != "4"){
	DisplayMenu();
	userInput = GetUserInput(); // update read
	RouteEm(userInput);
}
//end main

static void DisplayMenu(){
	System.Console.WriteLine("Welcome to Crimson Crust Pizza Shop!\n1: Preview a Plain Slice\n2: Preview a Cheese Slice\n3: to Preview a Pepperoni Slice\n4: EXIT\nEnter 1-4 to Select");
}

static string GetUserInput(){
    return Console.ReadLine();
}

static void RouteEm(string userInput){
    switch (userInput){
	case "1":
		PlainSliceStart();
		break;
	case "2":
		CheeseSliceStart();
		break;
	case "3":
		PepSliceStart();
		break;
    case "4":
        SayBye();
        break;
	default:
		DisplayErrorMessage();
		break;
	}
}

static void PlainSliceStart() {
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
    for (int i = rows; i > 0; i--){
        for (int j = 0; j < i; j++){
            Console.Write("*");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine("Press Any Key to Continue...");
    Console.ReadKey();
}

static void CheeseSliceStart() {
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
    for (int i = rows; i >= 1; i--){
        for (int j = 1; j <= i; j++){
            if (i == rows || j == i || j == 1){
            Console.Write("*");
            }
            else {
                Console.Write("#");
        }
    }
        Console.WriteLine();
}
System.Console.WriteLine("Press Any Key to Continue...");
Console.ReadKey();
}

static void PepSliceStart() {
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
    for (int i = rows; i >= 1; i--){
        for (int j = 1; j <= i; j++){
            if (i == rows || j == i || j == 1){
                Console.Write("*");
            }
            else {
                if (rnd.Next(0,5) == 0){
                    Console.Write("[]");
                }
                else {
                    Console.Write("#");
                }
            }
        }
        Console.WriteLine();
    }
    System.Console.WriteLine("Press Any Key to Continue...");
    Console.ReadKey();
}

static void SayBye(){
    Console.WriteLine("Bye!!!");
}

static void DisplayErrorMessage(){
    Console.WriteLine("Invalid Input, Try Again");
    System.Console.WriteLine("Press Any Key to Continue...");
    Console.ReadKey();
}