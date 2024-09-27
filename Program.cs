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
	System.Console.WriteLine("Welcome to Crimson Crust Pizza Shop!\nEnter 1 to Preview a Plain Slice\nEnter 2 to Preview a Cheese Slice\nEnter 3 to Preview a Pepperoni Slice\nEnter 4 to EXIT");
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
}

static string PepSliceStart() {
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
    for (int i = rows; i > 0; i--){

    }
}

static void SayBye(){
    Console.WriteLine("Bye!!!");
}

static void DisplayErrorMessage(){
    Console.WriteLine("Invalid Input, Try Again");
}