namespace _05.Listeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[ ] => listeleri temsil eder => array işareyi

            //string[] names = { "asdas", "asdasd" };
            //index numarası desem => 0'dan başlar
            //string[] names = new string[3];
            //names[0] = "Taner";
            //names[1] = "Taner";
            //names[2] = "Taner";

            //List<string> names = new List<string>() { "sadasd", "asdasd" };

            List<string> names = new(); //örneğe dönüştürmek için new kelimesini kullanıyoruz. Örneğe dönüştürme işleminde yazılımda "instance" üretme deniyor

            names.Add("Gaye"); //0
            names.Add("Gaye"); //1
            names.Add("Gaye"); //2
            names.Add("Gaye"); //3
            names.Add("Gaye"); //4
            names.Add("Gaye"); //5
            names.Add("Gaye"); //6
            names.Add("Gaye"); //7
            names.Add("Gaye"); //8
            names.Add("Gaye"); //9
            names.Add("Gaye"); //10


            names[12] = "Ahmet";

            Console.WriteLine(names.GetType());

            //class User
            //{
            //    public string Name;
            //}

            //var user1 = new User();
            //var user2 = new User();
            //var user3 = new User();

            ////List<User> users = new List<User>();
            //List<User> users = new();
        }
    }
}