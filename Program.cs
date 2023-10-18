using System.Text;

internal class Program
{

    private static void Main(string[] args)
    {
        
        static void ABC_ConsoleWR()
        {
            List<string> list = new List<string> { "а", "б", "в", "г", "ґ", "д", "е", "є", "ж", "з", "и", "і", "ї", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ь", "ю", "я" };
            foreach (string s in list)
            {
                Console.Write($"{s}, ");
            }
            Console.Write("\b\b.");
            Console.WriteLine("\nConsole Writing end successfuly");
        }
        static void ABC_FileWR()
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine("..", "text.txt")))
            {
                String sb = "";
                List<string> list = new List<string> { "а", "б", "в", "г", "ґ", "д", "е", "є", "ж", "з", "и", "і", "ї", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ь", "ю", "я" };
                foreach (string s in list)
                {
                    sb += $"{s}, ";
                }
                sb = sb.Substring(0, sb.Length - 2);
                sb += ".";
                sw.Write(sb.ToString());
            }
            Console.WriteLine("\nFile Writing end successfuly");
        }
        Thread thread1 = new Thread(ABC_FileWR); 
        Thread thread = new Thread(ABC_ConsoleWR);
        thread1.Start(); // Файл перший запускається але роботу закінчує пізніше
        thread.Start();
        

    }
}