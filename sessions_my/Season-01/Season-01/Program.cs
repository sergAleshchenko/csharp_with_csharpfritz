

class Test {

    static void display(object o)
    {
        Console.WriteLine(o.ToString());
    }

    static void Main(string[] args)
    {
        var i = 10;
        var someReallyLongVariableName = 9;
        var foo = "Something";

        display(someReallyLongVariableName);

        var c = 'C';
        display(c);

        display("Press enter to close...");
        Console.ReadLine();
    }
}
