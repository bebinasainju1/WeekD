using System;

public class Lab03
{

    public static void Main()

    {

        double curBal = 45.32;

        double amount;

        Console.Write("Please enter a amount to update account by $");

        amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("\n");

        Console.Write("Customer’s balance (before transaction) = $");

        Console.WriteLine(curBal + "\n");

        Console.Write("Requested update amount = $");

        Console.WriteLine(amount + "\n");

        double actAmount;

        actAmount = transaction(curBal, amount);

        curBal += actAmount;

        Console.Write("Actual update amount = $");

        Console.WriteLine(actAmount + "\n");

        Console.Write("Customer’s balance (after transaction) = $");

        Console.WriteLine(curBal + "\n");

        Console.WriteLine("\nThank you and good-bye!\n");

    }

    public static double transaction(double bal, double amount)
    {

        if (amount >= 0) //This fuction is for a positive dollar amount of deposit

            return amount;

        else //This function is for a negative or less than 0 dollar amount of withrawl

        { 
            if (bal + amount < 0)
                return -bal;
            else
                return amount;

        }

    }

}