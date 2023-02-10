using System.ComponentModel.DataAnnotations;

Console.WriteLine("How many seconds");
int seconds = Convert.ToInt32(Console.ReadLine());
float hours = seconds / 3600;
double frac = hours % 1;
float min = (float)frac * 60;
double frac2 = min % 1;
int sec = (int)frac2 * 60;
Console.WriteLine("Hours: " + hours);
Console.WriteLine("Minutes: " + min);
Console.WriteLine("Seconds left: "+sec);

