// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Write a program that reads in the radius and length of a cylinder and computes the area and volume using
// the formulas:

// area = radius * r * PI
// volume = area * length

double r,l,area,volume;

Console.WriteLine("Enter the radius and length of a cylinder:");
r = double.Parse(Console.ReadLine());
l  = double.Parse(Console.ReadLine());

area = r * r *  double.Pi;
volume = l * area;
Console.WriteLine("Your area is:"+ area.ToString("F4"));
Console.WriteLine("your volume is:" + volume.ToString("F4"));