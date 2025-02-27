namespace ITPCA_Test;
using System;
class Program
{
        static void Main()
    {
        //Section A:
        //Question 1

        int accountBalance = 10000;
        Console.WriteLine("How much would you like to withdraw from your account?");
        int withdrawl = int.Parse(Console.ReadLine());


        // Try catch block runs the code initially to verify certain conditions and catches any errors that occur
        try
        {
            if (withdrawl > accountBalance)
            {
                throw new ArgumentOutOfRangeException();
            }
            accountBalance -= withdrawl;
            Console.WriteLine($"You have withdrew: {withdrawl}. Your account balance is now: {accountBalance}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("You dont have sufficient funds");
        }
        finally
        {
            Console.WriteLine("Execution Complete.");
        }

        //Question 2

        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Are you a member? (Y/N): ");
        string membership = Console.ReadLine();

        if (age >= 60 || membership.ToLower() == "y")
        {
            Console.WriteLine("You are eligble for a 15.0% discount");
        }
        else
        {
            Console.WriteLine("You are not eligble for any discount");
        }

        //Section B
        //Question 3

        Console.WriteLine("Enter number of students: ");
        int numStudents = int.Parse(Console.ReadLine());
        int i = 0;

        int[] students = new int[numStudents];
        
        while (i < numStudents) {
            Console.WriteLine($"Enter student {i + 1}'s Grade: ");
            int grade = int.Parse(Console.ReadLine());
            if (grade > 100 || grade < 0 )
            {
                Console.WriteLine($"You have entered an incorrect Grade for student {i + 1}, please try again ");
            }
            else
            {
                students[i] = grade;
                i++;
            }
        }

        for (i = 1; i <= students.Length; i++) {

            switch (students[i-1]) {
                case >= 90:
                    Console.WriteLine($"Student {i}: Grade A");
                    break;
                case >= 80:
                    Console.WriteLine($"Student {i}: Grade B");
                    break;
                case >= 70:
                    Console.WriteLine($"Student {i}: Grade C");
                    break;
                case >= 60:
                    Console.WriteLine($"Student {i}: Grade D");
                    break;
                case <= 59:
                    Console.WriteLine($"Student {i}: Grade F");
                    break;
            }
        }
    }
}
