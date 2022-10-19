using Internal;
using System;
class hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello");
        childClass.msg();
    }
}

class childClass{
    public static void msg(){
        Console.WriteLine("message from child class");
    }
}