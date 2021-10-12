using System;
using System.Linq; // For string.All()

public class Assignment01
{
    public static void Main(string[] args)
    {
        int choice = -1;
        string tempChoice = string.Empty;

        bool wantToExit = false;
        string strWantToExit = string.Empty;

        do
        {
            System.Console.WriteLine("\n============== Assignment 01 ==============");
            System.Console.WriteLine("Creator: Ricky (019)");

            // Menu Selection
            do
            {
                Console.Write("\nMenu:\n1. Alphabet Pyramid\n2. Numerical Pyramid\n3. Factorial Calculator\n4. Reverse Number\n5. Number-To-Text\n6. Palindrome Checker\n\nInput (1-6): ");
                tempChoice =  Console.ReadLine();

                if(tempChoice.All(char.IsDigit)) {
                    choice = int.Parse(tempChoice);
                    if(0 <= choice && choice <= 6) {
                        break;
                    }
                }
            } while (true);
            
            System.Console.WriteLine();

            switch (choice)
            {
                case 1:
                    AlphabetTriangle();
                    break;
                case 2:
                    NumericalTriangle();
                    break;
                case 3:
                    CalcFactorial();
                    break;
                case 4:
                    ReverseNumber();
                    break;
                case 5:
                    NumberConverter();
                    break;
                case 6:
                    PalindromeChecker();
                    break;
                default:
                    break;
            }
            System.Console.WriteLine();

            // Ask to continue
            do
            {
                Console.Write("\nBack to Main Menu (y/n)? ");
                strWantToExit = Console.ReadLine();

                if(strWantToExit == "y" || strWantToExit == "Y") {
                    wantToExit = false;
                    break;
                }
                if(strWantToExit == "n" || strWantToExit == "N") {
                    wantToExit = true;
                    break;
                }
            } while (true);

        } while (wantToExit == false);

        Console.WriteLine("\nThank you!\n");
    }

    public static void PalindromeChecker()
    {
        string input = string.Empty;
        string revInput = string.Empty;

        // Input
        Console.WriteLine("=== Palindrome Checker ===");
        do
        {
            Console.Write("Input word to be checked: ");
            input = Console.ReadLine();

            if (input.Length > 0) {
                break;
            }

            Console.WriteLine("Please Input a Word! Try Again!");
        } while (true);

        // Reverse Input
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        revInput = new String(arr);

        if (revInput == input) {
            System.Console.WriteLine("The word '" + input + "' is a palindrome!");
        } else {
            System.Console.WriteLine("The word " + input + " is NOT a palindrome!");
        }
    }

    public static void NumberConverter()
    {
        string number = string.Empty;
        string input = string.Empty;
        // Input
        Console.WriteLine("=== Number Converter ===");
        do
        {
            Console.Write("Input Number: ");
            input = Console.ReadLine();

            if (input.Length > 0 && input.All(char.IsDigit)) {
                number = input;
                break;
            }

            Console.WriteLine("Please Input a Number! Try Again!");
        } while (true);

        // System.Console.WriteLine(number);

        foreach (char i in number)
        {
            switch (i)
            {
                case '0':
                    Console.Write("Zero ");
                    break;
                case '1':
                    Console.Write("One ");
                    break;
                case '2':
                    Console.Write("Two ");
                    break;
                case '3':
                    Console.Write("Three ");
                    break;
                case '4':
                    Console.Write("Four ");
                    break;
                case '5':
                    Console.Write("Five ");
                    break;
                case '6':
                    Console.Write("Six ");
                    break;
                case '7':
                    Console.Write("Seven ");
                    break;
                case '8':
                    Console.Write("Eight ");
                    break;
                case '9':
                    Console.Write("Nine ");
                    break;
                default:
                    Console.Write("- ");
                    break;
            }
        }
    }

    public static void ReverseNumber()
    {
        string input, tempStr = string.Empty;
        int number = -1;

        // Input
        Console.WriteLine("=== Reverse Number ===");
        do
        {
            Console.Write("Input Number: ");
            input = Console.ReadLine();

            if (input.Length > 0 && input.All(char.IsDigit)) {
                number = int.Parse(input);
                break;
            }

            Console.WriteLine("Please Input a Number! Try Again!");
        } while (true);

        string strNumber = number.ToString();

        // Reverse tempStr
        char[] arr = strNumber.ToCharArray();
        Array.Reverse(arr);
        tempStr = new String(arr);

        System.Console.WriteLine("Reversed Number: "+tempStr);
    }

    public static void CalcFactorial()
    {
        string input;
        int number = -1;

        // Input
        Console.WriteLine("=== Calculate Factorial ===");
        do
        {
            Console.Write("Input Number: ");
            input = Console.ReadLine();

            if (input.Length > 0 && input.All(char.IsDigit)) {
                number = int.Parse(input);
                break;
            }

            Console.WriteLine("Please Input a Number! Try Again!");
        } while (true);

        int factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }

        System.Console.WriteLine("Factorial of "+number+" is "+ factorial);
    }

    public static void NumericalTriangle()
    {
        string input, tempStr = string.Empty;
        int range = -1;

        // Input
        Console.WriteLine("=== Create Numerical Triangle ===");
        do
        {
            Console.Write("Input Range: ");
            input = Console.ReadLine();

            if (input.Length > 0 && input.All(char.IsDigit)) {
                range = int.Parse(input);
                break;
            }

            Console.WriteLine("Please Input a Number! Try Again!");
        } while (true);

        // System.Console.WriteLine("Range: " + range);

        // Triangle Generation
        string triangle = string.Empty;

        for (int i = 0; i < range; i++) {    
            // Spasi
            for (int j = range; j >= i; j--) {
                triangle += " ";
            }

            // Huruf Berurut
            for (int k = 0; k <= i; k++) {
                triangle += (k+1).ToString();
            }

            // Huruf Terbalik
            for(int l = 0; l < i; l++) {
                tempStr += (l+1).ToString();
            }

            if (String.IsNullOrEmpty(tempStr) == false) {
                // Reverse tempStr
                char[] arr = tempStr.ToCharArray();
                Array.Reverse(arr);
                tempStr = new String(arr);

                // Menambahkan tempStr(yg sdh reversed)
                triangle += tempStr;
            }

            triangle += "\n";
            tempStr = string.Empty;
        }
        System.Console.WriteLine(triangle);
    }

    public static void AlphabetTriangle()
    {
        char[] letters = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

        // Input
        int finalIndex = -1;
        char final = 'Z';
        string input;

        Console.WriteLine("=== Create Alphabetical Triangle (A to ?) ===");
        do
        {
            Console.Write("Input One Letter: ");
            input = Console.ReadLine();

            if (input.Length == 1 && Char.IsLetter(input[0])) {
                final = Char.ToUpper(input[0]);
                finalIndex = Array.IndexOf(letters, final);
                break;
            }

            Console.WriteLine("Please Input a Letter! Try Again!");
        } while (true);

        // Triangle Generation
        string triangle = string.Empty;
        string tempStr = string.Empty;

        // System.Console.WriteLine("final:"+final+"\nIndex:"+finalIndex);

        for (int i = 0; i <= finalIndex; i++) {    
            // Spasi
            for (int j = finalIndex; j >= i; j--) {
                triangle += " ";
            }

            // Huruf Berurut
            for (int k = 0; k <= i; k++) {
                triangle += letters[k];
            }

            // Huruf Terbalik
            for(int l = 0; l < i; l++) {
                tempStr += letters[l];
            }

            if (String.IsNullOrEmpty(tempStr) == false) {
                // Reverse tempStr
                char[] arr = tempStr.ToCharArray();
                Array.Reverse(arr);
                tempStr = new String(arr);

                // Menambahkan tempStr(yg sdh reversed)
                triangle += tempStr;
            }

            triangle += "\n";
            tempStr = string.Empty;
        }

        System.Console.WriteLine(triangle);
    }

    
}