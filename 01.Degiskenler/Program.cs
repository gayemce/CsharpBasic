namespace csharpBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //değişkenlere değer atanmadığında aldıkları ilk değer
            string name; //null
            int age; //0
            bool isActive; //false

            float n1 = 100;
            int n2 = 200;
            var n3 = n1 + n2;
            Console.WriteLine(n3.GetType());

            string nameLastName = "test test";

            name = "deneme";

            char karakter = 'A';

            string aciklama = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Console.WriteLine(nameLastName);

            Console.ReadLine();

        }
    }
}