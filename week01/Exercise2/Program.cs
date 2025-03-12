using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        // Get users percentage and asign a letter to it
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter;

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Assign a sign to letter
        string sign;
        int last_digit = percent % 10;

        if (last_digit >= 7){
            sign = "+";
        }
        else if (last_digit < 3){
            sign = "-";
        }
        else{
            sign = "";
        }
        
        string grade = $"{letter}{sign}";
        if (grade == "A+" || grade == "F+" || grade == "F-"){
            Console.WriteLine($"Your grade is: {letter}");
        }
        else{
            Console.WriteLine($"Your grade is: {grade}");
        }
        
        // Congratulate the user 
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}