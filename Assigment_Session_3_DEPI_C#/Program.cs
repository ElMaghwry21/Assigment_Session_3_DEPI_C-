namespace Assigment_Session_3_DEPI_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 1 : Check if a number is divisible by 3 and 4

            Console.WriteLine("Enter Your Number : ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");

            }
            else
            {
                {
                    Console.WriteLine("No");
                }
            }

            #endregion

            #region Part 2 : Check if a number is positive or negative

            Console.WriteLine("Check Your Number is positive or negative : ");

            int number1 = int.Parse(Console.ReadLine());
            

            if (number1 < 0 )
            {
                Console.WriteLine("Your Number is Negative ");
            }
            else
            {
                Console.WriteLine("Your Number is poditive ");
            };

            #endregion

            #region Part 3 : Find the maximum and minimum of three numbers

            Console.WriteLine("Enter 3 integers : ");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


            int max = Math.Max(num1, Math.Max(num2, num3));
            int min = Math.Min(num1, Math.Min(num2, num3));

            Console.WriteLine($"Max Element is : = {max}");
            Console.WriteLine($"Min Elment is : = {min}");

            #endregion

            #region Part 4 : Check if a number is even or odd

            Console.WriteLine("Enter Your num check if even or odd : ");

            int number0 = int.Parse(Console.ReadLine());


            if (number0 % 2 == 0 )
            
            {
                Console.WriteLine("Your number is Even : ");
            }
            else
            {
                Console.WriteLine("Your number is Odd : ");
            }

            #endregion

            #region Part 5 : Check if a character is a vowel or consonant

            Console.Write("Enter a character: ");
            char ch = char.Parse(Console.ReadLine()!);

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'I':
                case 'o':
                case 'u':
                case 'A': 
                case 'E':
                case 'O':
                case 'U':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonant");
                    break;
            }


            #endregion

            #region Part 6 : Print all numbers from 1 to n

            Console.Write("Enter an integer number: ");
            int number10 = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= number10; i++)
            {
                Console.Write(i + " ");
            }

            #endregion

            #region Part 7 : Print the multiplication table of a number 

            Console.Write("Enter an integer number: ");
            int number5 = int.Parse(Console.ReadLine()!);

            
            for (int i = 1; i <= 12; i++)
            {
                Console.Write((number5 * i) + " ");
            }

            #endregion

            #region Part 8 : Print all even numbers from 1 to n
            Console.Write("Enter an integer number: ");
            int number11 = int.Parse(Console.ReadLine()!);

         
            for (int i = 1; i <= number11; i++)
            {
            
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            #endregion

            #region Part 9 : Print all odd numbers from 1 to n
            Console.Write("Enter the base number: ");
            int baseNum = int.Parse(Console.ReadLine()!);

            Console.Write("Enter the exponent (power): ");
            int exponent = int.Parse(Console.ReadLine()!);

            int result = 1;

            for (int i = 1; i <= exponent; i++)
            {
                result *= baseNum;
            }

            Console.WriteLine($"Output: {result}");

            #endregion

            #region Part 10 : Calculate the total, average, and percentage of marks obtained in five subjects

            double sub1 = double.Parse(Console.ReadLine()!);
            double sub2 = double.Parse(Console.ReadLine()!);
            double sub3 = double.Parse(Console.ReadLine()!);
            double sub4 = double.Parse(Console.ReadLine()!);
            double sub5 = double.Parse(Console.ReadLine()!);

            double totalMarks = sub1 + sub2 + sub3 + sub4 + sub5;

            double averageMarks = totalMarks / 5;

            double percentage = (totalMarks / 500) * 100;

            Console.WriteLine($"Total marks = {totalMarks}");
            Console.WriteLine($"Average Marks = {averageMarks}");
            Console.WriteLine($"Percentage = {percentage}%");
            #endregion

            #region Part 11 : Find the number of days in a month using switch case

            Console.Write("Enter Month Number (1-12): ");
            int monthNumber = int.Parse(Console.ReadLine()!);

            int days = monthNumber switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28,
                _ => -1 
            };

            if (days == -1)
            {
                Console.WriteLine("Invalid Month Number!");
            }
            else
            {
                Console.WriteLine($"Days in Month: {days}");
            }

            #endregion

            #region Part 12 : Simple Calculator using switch case
            Console.Write("Enter the first number: ");
            double numOne = double.Parse(Console.ReadLine()!);

            Console.Write("Enter an operator (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine()!);

            Console.Write("Enter the second number: ");
            double numTwo = double.Parse(Console.ReadLine()!);

            double result = op switch
            {
                '+' => numOne + numTwo,
                '-' => numOne - numTwo,
                '*' => numOne * numTwo,
                '/' => numTwo != 0 ? numOne / numTwo : double.NaN, // منع القسمة على الصفر
                _ => double.NaN
            };

            if (double.IsNaN(result))
            {
                Console.WriteLine("Invalid Operation or Division by Zero!");
            }
            else
            {
                Console.WriteLine($"Result: {numOne} {op} {numTwo} = {result}");
            }

            #endregion

            #region Part 13 : Reverse a string
            Console.Write("Enter a string: ");
            string input = Console.ReadLine()!;

            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine($"Reversed String: {reversed}");
            #endregion

            #region Part 14 : Reverse an integer
            Console.Write("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine()!);
            int reversedNum = 0;

            while (number != 0)
            {
                int remainder = number % 10;       
                reversedNum = reversedNum * 10 + remainder;
                number /= 10;
            }

            Console.WriteLine($"Reversed Integer: {reversedNum}");
            #endregion

            #region Part 15 : Find all prime numbers in a given range
            Console.Write("Input starting number of range: ");
            int startRange = int.Parse(Console.ReadLine()!);

            Console.Write("Input ending number of range: ");
            int endRange = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"The prime numbers between {startRange} and {endRange} are:");

            for (int num = startRange; num <= endRange; num++)
            {
                if (num < 2) continue;

                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break; 
                    }
                }

                if (isPrime)
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
            #endregion

            #region Part 16 : Convert decimal to binary
            Console.Write("Enter a number to convert : ");
            int decimalNumber = int.Parse(Console.ReadLine()!);
            int originalNumber = decimalNumber;
            string binaryResult = "";

            if (decimalNumber == 0)
            {
                binaryResult = "0";
            }
            else
            {
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % 2;
                    binaryResult = remainder + binaryResult;
                    decimalNumber /= 2;
                }
            }

            Console.WriteLine($"The Binary of {originalNumber} is {binaryResult}.");
            #endregion

            #region Part 17 : Check if three points lie on a single straight line
            Console.WriteLine("Enter coordinates for the first point (x1, y1):");
            double x1 = double.Parse(Console.ReadLine()!);
            double y1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter coordinates for the second point (x2, y2):");
            double x2 = double.Parse(Console.ReadLine()!);
            double y2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter coordinates for the third point (x3, y3):");
            double x3 = double.Parse(Console.ReadLine()!);
            double y3 = double.Parse(Console.ReadLine()!);

            double slope1 = (y2 - y1) * (x3 - x2);
            double slope2 = (y3 - y2) * (x2 - x1);

            if (slope1 == slope2)
            {
                Console.WriteLine("The three points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("The three points do NOT lie on a single straight line.");
            }
            #endregion

            #region Part 18 : Evaluate worker efficiency based on time taken
            Console.Write("Enter the time taken by the worker (in hours): ");
            double timeTaken = double.Parse(Console.ReadLine()!);

            string message = timeTaken switch
            {
                >= 2 and <= 3 => "The worker is considered highly efficient.",
                > 3 and <= 4 => "The worker is instructed to increase their speed.",
                > 4 and <= 5 => "The worker is provided with training to enhance their speed.",
                > 5 => "The worker is required to leave the company.",
                _ => "Invalid time entered or the worker finished in less than 2 hours."
            };

            Console.WriteLine(message);
            #endregion

            #region Part 19 : Print the Identity Matrix of size n * n
            Console.Write("Enter the size of the matrix (n): ");
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"The Identity Matrix of size {n} * {n} is:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
            #endregion

            #region Part 20 : Calculate the sum of all elements in an array

            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"The sum of all elements in the array is: {sum}");


            #endregion

            #region Part 21 : Merge two arrays and sort the result in ascending order
            int[] array1 = { 1, 3, 5, 7 };
            int[] array2 = { 2, 4, 6, 8 };

            int[] mergedArray = array1.Concat(array2).OrderBy(x => x).ToArray();

            Console.WriteLine("The merged array in ascending order:");
            Console.WriteLine(string.Join(", ", mergedArray));
            #endregion

            #region Part 22 : Find the frequency of each element in an array

            int[] numbers00 = { 1, 2, 2, 3, 4, 1, 2, 5, 3 };

            var frequencyQuery = numbers00.GroupBy(x => x)
            .Select(g => new { Element = g.Key, Count = g.Count() });

            Console.WriteLine("Element frequency in the array:");
            foreach (var item in frequencyQuery)
            {
                Console.WriteLine($"Number {item.Element} is repeated {item.Count} time(s).");
            }

            #endregion


            #region Part 23 : Find the maximum and minimum elements in an array

            int[] numbers01 = { 45, 12, 78, 3, 89, 23 };

            int maxElement = numbers01.Max();
            int minElement = numbers01.Min();

            Console.WriteLine($"The maximum element in the array is: {maxElement}");
            Console.WriteLine($"The minimum element in the array is: {minElement}");

            #endregion











        }
    }
}
