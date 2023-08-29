// See https://aka.ms/new-console-template for more information

using System;
{
    {
        // two float variables with one being set to zero. tbh i dont know what it does exactly.
        float myFloat = 65.4f;
        float myOtherFloat = 0.0f;
        float result = 0f;

       // Initializes an int with a random range from 2 to 30.
        Randum rand = new Randum();
        int myInt = rand.Next(2, 30);


        // Assiges result to the Divide method and pass in the two variables as arguments.
        try
        {
            result = Divide(myFloat, myOtherFloat);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Please enter a number other than zero.");
            myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

            try
            {
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            finally
            {
                Console.WriteLine("Calculations compleated with a result of " + result);
            }
            try
            {
                CheckAge(myInt);
            }catch
            {
                Console.WriteLine($"You are {myInt}, you are not old enough!");
            }
        }
    }

    /// <summary>
    ///  A method that returns a float and takes two parameters.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns><</returns>
    static float Divide(float x, float y)
    {
        if(y == 0)
        {
            throw new DivideByZeroException();
        }
        else
        {
            return x / y;
        }
    }

    /// <summary>
    /// If the parameter is greater than or equal to 17 then it prints to console, "You are <age>, you can play mature games!".
    /// </summary>
    /// <param name="age"></param>
    static void CheckAge(int age)
    {
        if (age >= 17) 
        {
            Console.WriteLine($"You are {age}, you can play mature games!");
        }
        else
        {
            throw new ArgumentException();
        }
    }


}

 