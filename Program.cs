using System; 

    class Program
{

    public static void Main(string[]args)
    {
        Console.WriteLine("Provide 1 number to perform the addition operation");
        int num1 = int.Parse (Console.ReadLine());

        Console.WriteLine("Provide a number to add to " + num1 + ".");
        int num2 = int.Parse (Console.ReadLine());

        Console.WriteLine(num1 + num2);

        Console.WriteLine("Provide 1 number to perform the subtraction operation");
        int num3 = int.Parse (Console.ReadLine());

        Console.WriteLine("Provide a number to subtract from " + num3 + ".");
        int num4 = int.Parse (Console.ReadLine());

        Console.WriteLine(num3 - num4);

        Console.WriteLine("Provide 1 number to preform the multiplication operation");
        int num5 = int.Parse (Console.ReadLine());

        Console.WriteLine("Provide a number to multiply " + num5 + ".");
        int num6 = int.Parse (Console.ReadLine());

        Console.WriteLine(num5 * num6);

        Console.WriteLine("Provide 1 number to preform the Integer Division operation");
        int num7 = int.Parse (Console.ReadLine());

        Console.WriteLine("Provide a number to divide " + num7 + ".");
        int num8 = int.Parse (Console.ReadLine());

        Console.WriteLine(num7 / num8);

        Console.WriteLine("Provide a number for the Floating Point operation");
        float num9 = float.Parse (Console.ReadLine());

        Console.WriteLine("Provide a decimal number to divide" + num9 + ".");
        float num10 = float.Parse (Console.ReadLine());

        Console.WriteLine(num9 / num10);

        Console.WriteLine("Provide a number to preform the modulus operation");
        int num11 = int.Parse (Console.ReadLine());

        Console.WriteLine("Provide a number to modulus " + num11 + ".");
        int num12 = int.Parse (Console.ReadLine());

        Console.WriteLine(num11 % num12);






    }



}






















