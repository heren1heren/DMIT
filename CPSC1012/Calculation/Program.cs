/*
*this demo will cover the do-while loop
* you can do so, by demonstrate a menu selection
* Add, Sub, Multiply, Division, exit
* the user will be asked to chose an option,
* depending on the option, the calculation will be performed
* the program will continue until the user selects exit
* the program will demonstration exception handling of errors instead of defensive programming

**/

string inputValue = "";
char menuChoice = ' ';
int firstNumber = 0;
int secondNumber = 0;
double calculationResult = 0.0;
Random random = new Random();

//Do while loop
//post test structure which means the loop will be done at least once

int i = 0;
do
{
    Console.WriteLine("our choices for a calculations are:");
    Console.WriteLine("a) add");
    Console.WriteLine("b) sub");
    Console.WriteLine("c) multiply");
    Console.WriteLine("d) division");
    Console.WriteLine("x) exit");
    Console.Write("Enter your calculation choose");
    firstNumber = random.Next(0, 101);
    firstNumber = random.Next(0, 101);

    bool validFlag = false
    try
    {
        inputValue = Console.ReadLine();
        menuChoice = char.Parse(inputValue);
        switch (char.ToUpper(menuChoice))
        {
            case 'A':
            {
                //ask the user for their answer
                // valid the incoming vvalue to bee a number 
                do {
                    validFlag = true;
                    Console.Write($"\what  is the asnwers to ")
                    bool lidFlag = false;
                } while(!validFlag)

                break;
            }
            case 'C':
            {
                //ask the user for their answer
                // valid the incoming value to bee a number 
                do {
                    validFlag = true;
                    Console.Write($"\what  is the answers to  {firstNumber} * {secondNumber} *");
                    inputValue = Console.ReadLine();
                    if(!int.TryParse(inputValue, out userGuessInterger))
                } while(!validFlag)
                calculationResult = firstNumber * secondNumber
                if(userGuessInterger == calculationResult) {
                    // announce
                }
                break;
            }
            default:
            {
                Console.WriteLine($"Error: your menuchoice is invalid, try again");
                break;
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
} while (char.ToUpper(menuChoice) != 'X');
