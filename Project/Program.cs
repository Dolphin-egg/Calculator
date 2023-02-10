string rerun = "n";
do
{

    //Console.Write("Name\n>> ");
    //string name = Console.ReadLine();
    //Console.Write("Ok " + name + "\n");

    int numberadd(int num1, int num2)
    {
        int answer = num1 + num2;
        return answer;
    }

    int numbersub(int num1, int num2)
    {
        int answer = num1 - num2;
        return answer;
    }

    int numbermul(int num1, int num2)
    {
        int answer = num1 * num2;
        return answer;
    }

    int numberdiv(int num1, int num2)
    {
        int answer = num1 / num2;
        return answer;
    }

    Console.Write("Enter number 1\n>> ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Enter number 2\n>> ");
    int num2 = int.Parse(Console.ReadLine());

    string yn()
    {
        Console.Write("1. Add \n2. Subtract \n3. Multiply \n4. Divide \n>> ");
        string choice = Console.ReadLine();
        return choice;
    }
    string choice = yn();

    int result;
    if (choice == "1")
    {
        result = numberadd(num1, num2);
    }
    else if (choice == "2")
    {
        result = numbersub(num1, num2);
    }
    else if (choice == "3")
    {
        result = numbermul(num1, num2);
    }
    else
    {
        result = numberdiv(num1, num2);
    }


    Console.Write(result + "\n" + "Do you want to do another calculation?\n>>" );
    rerun = Console.ReadLine();
}
while (rerun == "y");