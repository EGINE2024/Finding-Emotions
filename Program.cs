namespace EvresiSunais8imatwn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Καλώς ήρθες στην εφαρμογή μας!");

            List<string> ArnitikesLekseis = new ArnitikesLekseisLists().ArnitikesLekseis;
            List<string> ThetikesLekseis = new ThetikesLekseisLists().ThetikesLekseis;

            Console.WriteLine("Γράψε μου μια πρόταση!");
            string myProtasi = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(myProtasi))
            {
                Console.WriteLine("Γράψε μου πρόταση, όχι κενό!");
                myProtasi = Console.ReadLine();
            }

            List<string> myProtasiWords = new List<string> { };
            myProtasiWords = myProtasi.Split(" ").ToList();
            bool IsInLists = false;

            foreach (string word in myProtasiWords)
            {
                if (ThetikesLekseis.Contains(word.ToLower()))
                {
                    Console.WriteLine("Έχεις θετική συναισθηματική κατάσταση!");
                    IsInLists = true;
                    break;
                }
                else if (ArnitikesLekseis.Contains(word.ToLower()))
                {
                    Console.WriteLine("Έχεις αρνητική συναισθηματική κατάσταση!");
                    IsInLists = true;
                    break;
                }

            }

            if(!IsInLists)
                Console.WriteLine("Ουδέτερη συναισθηματική κατάσταση!");
        }
    }
}
