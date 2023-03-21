internal class Program
{
    private static void Main(string[] args)
    {
        object s = "asd";
        object t = new string("asd");

        Console.WriteLine(s == t); // bool.ReferenceEquals(s,t) false
        Console.WriteLine((string)s == (string)t); // bool.Equals(s,t)  true
        
        
        object s1 = "asd";
        object t1 = "asd";
        Console.WriteLine(s1 == t1); // bool.Equals(s1,t1) true
        Console.WriteLine(bool.ReferenceEquals(t1,s1)); // true
        

        

        object x = 15;
        object y = 15;

        Console.WriteLine(x == y); // bool.ReferenceEquals(x,y) false
        
        Console.WriteLine((int)x == (int)y); //bool.Equals(x,y) true
        

        // object, reference tip   '==' => bool.ReferenceEquals()
        // primitive, string tip  '==' => bool.Equals()
        
    }
}