

void FindFibonacciSeriesS()
{
    int firstNumber = 0, secondNumber = 1, nextNumber, numberOfElements;

    Console.Write("Enter the number of elements to Print: ");
    numberOfElements = Convert.ToInt32(Console.ReadLine());

    if (numberOfElements < 2)
        Console.Write("Please Enter a number greater than two");
    else
    {
        for (int i = 2; i < numberOfElements; i++)
        {
            nextNumber = firstNumber + secondNumber;
            Console.WriteLine(nextNumber + " ");
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
    }
}

void PyramidFibonacciSeries()
{
    int firstNumber = 0, secondNumber = 1, nextNumber, numberOfElements;

    Console.Write("Enter the number of elements to Print: ");
    numberOfElements = Convert.ToInt32(Console.ReadLine());

    if (numberOfElements < 2)
        Console.Write("Please Enter a number greater than two");
    else
    {
        for (int i = 1; i < numberOfElements; i++)
        {
            firstNumber = 0;
            secondNumber = 1;
            Console.Write(secondNumber + "\t");

            for (int j = 1; j < i; j++)
            {
                nextNumber = firstNumber + secondNumber;
                Console.Write(nextNumber + "\t");
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            Console.WriteLine();
        }
    }
}

FindFibonacciSeriesS();
PyramidFibonacciSeries();



