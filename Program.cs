// TryParse And While Loop


Console.Clear();

// TryParse: Validate and convert at the same time!

bool isValid;
int convertedNum;
string dataToCOnvert = "8";

// our booean is equal,    to the result of TryParse,      string  to convert,         where to save the int
         isValid    =         int.TryParse(                  dataToCOnvert,                out convertedNum);
// int.TryParse takes in our string, attempts to convert it, and if successfull will save the newly converted integer into the variable after the word 'out' , and return a true value to be saved in isValid.
// if the string is NOT valid, the int variable convertedNum will reamin empty / will convert to 0, and false will get saved into isValid

Console.WriteLine(" did the number convert properly? " + isValid);
Console.WriteLine("the value of our integer variable is " + convertedNum);

//Loops

// Loops are for when we have a set of code that will likely run several times in a row.
// this loop will run for as long as the condition is true
// Think of it as an if statement that happens over and over again.

// bool goStop = true;
// while(goStop){
//     Console.WriteLine("The end is never ");
// }

// this is an infinite loop. if you get stuck in a infinite loop, click into your terminal and press Ctl + C

bool runLoop = true;
while(runLoop){
    Console.WriteLine("I did the thing ");
    // runLoop = false;
    // runLoop = !runLoop;
    // runLoop = !true;
    Console.WriteLine("Our bool is now " + runLoop);
    break;
}
Console.WriteLine("I escaped the loop!");

// To stop a loop , we have a few options. The above is assigning a false value to our variable that is being used as a condition for the while loop.
// You can also achieve reassigning the bool value the not operator (!)
// You can also use a break; in order to cut off a loop at a given point and make it stop immediately. Note that any code inside the loop after the break; will NOT run!

int counter = 0;
bool runAgain = true;

while(counter < 5){
    counter++;
    Console.WriteLine($"This loop has run {counter} times");
}

// Validation with a while loop and the use of TryParse
bool validEntry = false;
int convertedInput;

while(validEntry == false){
    Console.WriteLine("Please enter a valid number");

    string userInput = Console.ReadLine();
    validEntry = int.TryParse( userInput, out convertedInput);
    Console.WriteLine("The user entered " + userInput);
    Console.WriteLine("Our bool validEntry is now " + validEntry);
}
Console.WriteLine("You entered a valid number and escaped the loop!");
// you are stuck in this loop until you enter a number that TryParse can succesfully convert.
// If the number is to large it will also return a false.

string userResp = "";

while(userResp != "Yes" || userResp != "No"){
    Console.WriteLine("Would you like to exit the loop?");
    userResp = Console.ReadLine();
    if(userResp != "Yes"){
        Console.WriteLine("That was not a valid response... Try again");
    }

}
Console.WriteLine("You escaped");