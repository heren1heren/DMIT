// Write a program that prompts the user to enter the side of a hexagon and displays its area. The formula for
// computing the area of a hexagon is:
// area = ((3*srt(3))/2) * (s*s) where s is the length of a hexagon side

string inputValue = "";
double area,length;
Console.WriteLine("Enter your hexagon length");
length = double.Parse(Console.ReadLine());

area = (length*length) * ((3*Math.Sqrt(3))/2);
Console.WriteLine("your answer: " + area.ToString("F4"));
