using System;

//ref link:https://www.youtube.com/watch?v=ZB3dcXfVXy8&list=PL259BC2977085CF37&index=5
//

static class MainClass
{
    // Generic
    class at1<T, R>
    {
        public T FirstName { get; set; }
        public R LastName { get; set; }
    }
    class at2<T, R>
    {
        public T FirstNamer { get; set; }
        public R LastName { get; set; }
    }

    static void Main()
    {
        // Anonymous
        var instance = new { FirstName = "Kulpot", LastName = "King" };
        var instance2 = new { FirstName = 5.0, LastName = "King" };
        var instance3 = new { FirstNamer = 5.0, LastName = "King" };
        Console.WriteLine(instance.GetType());
        Console.WriteLine(instance2.GetType());
        Console.WriteLine(instance3.GetType());

        // Generic
        var instance4 = new at1<string, string> { FirstName = "Kulpot", LastName = "King" };
        var instance5 = new at1<double, string> { FirstName = 5.0, LastName = "King" };
        var instance6 = new at2<double, string> { FirstNamer = 5.0, LastName = "King" };
        Console.WriteLine(instance4.GetType());
        Console.WriteLine(instance5.GetType());
        Console.WriteLine(instance6.GetType());
    }
}