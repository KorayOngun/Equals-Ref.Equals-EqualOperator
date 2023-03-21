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
        // değerleri aynı 'new'lenmemiş 2 string aynı referansı gösterir
        Console.WriteLine(s1 == t1); // bool.Equals(s1,t1) true
        Console.WriteLine(bool.ReferenceEquals(t1,s1)); // true
        t1 = "a";
        Console.WriteLine(bool.ReferenceEquals(t1, s1)); // false


        string s2 = "asd";
        string t2 = new string("asd");
        Console.WriteLine(bool.ReferenceEquals(s2,t2)); // false    
        Console.WriteLine(s2==t2); // true    


        object x = 15;
        object y = 15;

        Console.WriteLine(x == y); // bool.ReferenceEquals(x,y) false
        
        Console.WriteLine((int)x == (int)y); //bool.Equals(x,y) true



        // object, reference tip   '==' => bool.ReferenceEquals()
        // primitive, string tip  '==' => bool.Equals()
        
    }
}