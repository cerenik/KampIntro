using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();

            isimler.Add("Ceren");
            isimler.Add("Burcu");

            isimler.ToList();
        }

    }
}
