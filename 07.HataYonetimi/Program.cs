namespace _07.HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           try
            {
                int a = 0;
                int b = 0;
                //int sonuc = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //int x = int.MaxValue;

            //checked
            //{
            //    x++;
            //}


            //unchecked
            //{
            //    Console.WriteLine("Bunu yapamazsın!");
            //}

            Console.WriteLine("Ben her halükarda çalışırım!");
        }
    }
}