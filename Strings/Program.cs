namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Engin Demiroğ";


            var result = sentence.Length; //bu cümlenin kaç karakterden oluştuğunu verir
            var result2 = sentence.Clone(); //klonlama amacıyka kullanılır
            sentence = "My name is Derin Demioğ";

            bool result3= sentence.EndsWith("ğ"); //ğ ile bitiyor mu?
            bool result4 = sentence.StartsWith("May name"); // My name ile başlıyor mu?

            var result5 = sentence.IndexOf("namee");  //bir metin içinde bie ifadeyi aramak için kullanılır
            var result6 = sentence.IndexOf(" ");  //bulduğu ilk boşluğu verir
            var result7 = sentence.LastIndexOf(" "); // boşluğu aramaya en sondan başlar
            var result8 = sentence.Insert(0, "Hello, ");// metine başka metin ekleme
            var result9 = sentence.Substring(3,4);  //metni parçalamak için
            var result10 =sentence.ToLower();  //küçük harfe çevirir
            var result11 = sentence.ToUpper();  //büyük harfe çevirir
            var result12 = sentence.Replace(" ", "-");//metin içinde belli karakterleri değiştirir
            var result13 = sentence.Remove(2,5);// belli bir index sonrasını atmak için kullanılır

            Console.WriteLine(result13);

        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)


            {

                Console.WriteLine(item);

            }
            string city2 = "İstanbul";


            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}