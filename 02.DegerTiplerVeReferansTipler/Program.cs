namespace _02.DegerTiplerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Değer tiplerin bellekte değeri tutulur
            string name = "Gaye";
            string name2 = name;
            name2 = "Ahmet";

            Console.WriteLine(name);
            Console.WriteLine(name2); //değer tip örneği


            //Referans tiplere bellekte referans değeri atanır
            //Bir eşitleme yapıldığı zaman, referans tipler referens değerini değil numarasını alır
            //Bir değişiklik yapıldığında o referans numarasına sahip kaç değişken varsa hepsi değişir
            User user = new();
            User user2 = user;
            user2.Name = "Ahmet";

            Console.WriteLine(user.Name);
        }
    }
}

class User
{
    public string Name = "Gaye";
}
        }
    }
}