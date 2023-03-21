

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
        
        Console.WriteLine(s == t); // bool.ReferenceEquals(s,t)  || bool.ReferenceEquasl((string)s,string(t)) => false
        Console.WriteLine((string)s == (string)t); // bool.Equals(s,t)  true


        //   değerleri aynı 'new'lenmemiş 2 string aynı referansı gösterir
        object s1 = "asd";
        object t1 = "asd";

        Console.WriteLine(s1 == t1); // true
        Console.WriteLine(bool.ReferenceEquals(t1,s1)); // true
        string.Equals(s1,t1);

        t1 = "a";
        Console.WriteLine(bool.ReferenceEquals(t1, s1)); // false
        
      
        string s2 = "asd";
        string t2 = new string("asd");

        Console.WriteLine(s2 == t2); // true   
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



