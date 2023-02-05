namespace BotigaCistella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Botiga
            string[] productesBotiga;
            productesBotiga = new string[20];
            double[] preus;
            preus = new double[20];
            int nElemBotiga = 0;

            //Cistella
            string[] productesCistella;
            productesCistella= new string[20];
            int[] quantitats;
            quantitats= new int[20];
            int nElemCistella = 0;
            int diners = 0;

        }

        static void AfegirProducte(string producte, double preu, string[] productes, double[] preus, ref int nElem)
        {
            if (nElem < productes.Length)
            {
                productes[nElem] = producte;
                preus[nElem] = preu;
                nElem++;
            }
            else
            {
                Console.Write("Vols ampliar la botiga?");
            }
        }
    }
}