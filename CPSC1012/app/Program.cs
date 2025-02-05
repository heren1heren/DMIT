// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// DECLARE audienceSize as Integer

// DECLARE conversionRate as Float
// DECLARE numberOfConversions 
// PROMPT: Enter the audince size: (read)
// PROMPT: Enter the conversion rate: (read)
// //process: 
// Calculate: numberOffC = AS * CR
// output:
// PRINT the numberOfC(round to nearest whole number)

// default of string is null so we need to explicitly define inputValue.
int audienceSize;
double conversionRate, numberOfConversions;
string inputValue = "";
Console.Write("Enter the audience size ");
inputValue = Console.ReadLine();
// need to convert inputValue from String( default read value) -> desired data type( numeric)
// syntax: datatype.Parse(<string value>)
 audienceSize = int.Parse(inputValue);

Console.WriteLine("Enter the conversionRate: ");
string inputValue2 = Console.ReadLine();
 conversionRate= double.Parse(inputValue2);
// //processing
numberOfConversions = conversionRate * audienceSize ;
Console.WriteLine("our result is : " + numberOfConversions);
