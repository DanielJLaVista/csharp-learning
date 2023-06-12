using System;
namespace Variables;

class Program {
    static void Main(string[] args) {
        var number = 2;
        var count = 10;
        var totalPrice = 20.95f;
        var character = 'A';
        var firstName = "Daniel";
        var isWorking = true;

        Console.WriteLine(number);
        Console.WriteLine(count);
        System.Console.WriteLine(totalPrice);
        System.Console.WriteLine(character);
        System.Console.WriteLine(firstName);
        System.Console.WriteLine(isWorking);

        System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

        const float Pi = 3.14f;

        //Type conversion
        byte b = 1;
        int i = b;

        System.Console.WriteLine(i);

        int i2 = 1000;
        byte b2 = (byte)i2;

        System.Console.WriteLine(b2);
        try {
            var number2 = "1234";
            byte b3 = Convert.ToByte(number2);

            System.Console.WriteLine(b3);
        }
        catch (Exception) {
            System.Console.WriteLine("Number could not be converted to a byte");
        }
        try {
            string str = "true";
            bool b4 = Convert.ToBoolean(str);
            System.Console.WriteLine(b4);
        }
        catch (Exception) {
            System.Console.WriteLine("String could not be converted to a boolean");
        }
    }
}