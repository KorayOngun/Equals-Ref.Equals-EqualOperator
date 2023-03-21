

using System.Text.Json.Serialization;

internal class Program
{
    private unsafe static void Main(string[] args)
    {
        //   object, reference tip   '==' operatörü => bool.ReferenceEquals() referans karşılaştırma
        //   primitive, string tip  '==' operatörü => bool.Equals() içerik karşılaştırma
        
        // 'new'lenmiş string referans adresi değişir
        object s = "asd";
        object t = new string("asd");
        
        Console.WriteLine($"object  s == t  {s == t}"); // object.operator,  bool.ReferenceEquals(s,t)  => false
        Console.WriteLine($"object  (string)s==(string)t  {(string)s == (string)t}"); // string.operator =>  bool.Equals(s,t)  true



        //   değerleri aynı 'new'lenmemiş 2 string aynı referansı gösterir
        object s1 = "asd";
        object t1 = "asd";

        Console.WriteLine( $"object  s1 == t1 {s1 == t1}"); // bool.ReferenceEquals(s1,t1) true
        Console.WriteLine(bool.ReferenceEquals(t1,s1)); // true


        t1 = "a";
        Console.WriteLine(bool.ReferenceEquals(t1, s1)); // false
        
      
        string s2 = "asd";
        string t2 = new string("asd");

        Console.WriteLine(s2 == t2); // true bool.Equals(s2,t2)   string.operator
        Console.WriteLine(bool.ReferenceEquals(s2,t2)); // false    
         

        //-----------------------------------------------------------------------------------------------
        object x = 15;
        object y = 15;

        Console.WriteLine(x == y); // bool.ReferenceEquals(x,y) false
        Console.WriteLine((int)x == (int)y); //bool.Equals(x,y) true

        int i = 15;
        int j = 15;
        Console.WriteLine(i==j); //  bool.Eqauls(i,j) -- true
        Console.WriteLine( (object)i == (object)j); // bool.ReferenceEquals(i,j) -- false
        Console.WriteLine(bool.Equals(i,j)); // true


    }
}



