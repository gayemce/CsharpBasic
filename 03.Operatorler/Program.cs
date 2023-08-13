namespace _03.Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /Operatörler
            //= eşittir operatöri => değer ataması yapar
            //== kontrol  operatörü => a ve b değerini kontrol eder

            int a = 0;
            int b = 1;

            var c = (a == b);

            // + - * / Matematiksel operatörler

            int r = ((5 * 2) + 5) - 0;

            // += eşittirden sonraki değeri + işaretinden önceki değere ekler
            // -= eşittirden sonraki değeri - işaretinden önceki değerden çıkartır

            int z = 1;

            z += 5; //===> z = z + 5;

            //++; değişkenin değerini 1 artırır
            //--; değişkenin değerini 1 azaltır
            int x = 1;
            x++;
            x--;


            //+ operatörü string değerlerde birleştirme işlemi yapar;

            string name = "Gaye" + " " + "Tekin"; //Taner Saydam
            string name2 = $"{name} 22 yaşında "; // ==> Gaye Tekin 22 yaşında 
                                                  //@ operatör  ters bölü işaretini kullanmamızı sağlıyor;
            string url = @"http:\"; //==> http:\ 

            var result = name + 2; //Rakam + string birleştirme işlemi yapar ==> Taner Saydam2

            //% => mod operatörü sayının verilen sayıya tam bölünüp bölünmediğini kontrol eder 

            var r2 = (x % 2);
        }
    }
}