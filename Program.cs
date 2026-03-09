namespace ExempluClase
{
    class Program
    {
        static void Main()
        {
            //	Instantierea unui obiect de tip FiguraGeometrica utilizand constructorul fara parametri
            //	Tipul variabilei f este 'var' (determinat de compilator)
            var figur1 = new FiguraGeometrica();
            string figura1AsString = figur1.Info();
            Console.WriteLine(figura1AsString);
            Console.WriteLine($"Este poligon? {figur1.EstePoligon}");

            //	Instantierea unui obiect de tip FiguraGeometrica utilizand constructorul cu parametri
            //	Tipul variabilei f1 este explicit 'FiguraGeometrica'
            FiguraGeometrica figura2 = new FiguraGeometrica("patrat", 4);
            string figura2AsString = figura2.Info();
            Console.WriteLine(figura2AsString);
            Console.WriteLine($"Este poligon? {figura2.EstePoligon}");

            Console.WriteLine("Introdu nr de laturi: ");
            int nrLat = Int32.Parse(Console.ReadLine());
            int[] dim=new int[nrLat];
            Console.WriteLine("Dimensiuni Laturi: ");
            for (int i = 0; i < nrLat; i++)
            {
                Console.WriteLine($"latura " + i);
                dim[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introdu denumirea figurii:");
            string den = Console.ReadLine();
            FiguraGeometrica figura3 = new FiguraGeometrica(den, nrLat);
            figura3.SetDimensiuniLaturi(dim);
            Console.WriteLine(figura3.Info());
            Console.WriteLine($"Perimetru: {figura3.Perimetru}");


            Console.WriteLine("\nJoc: Generare figuri");

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                int nr = rnd.Next(1, 8);

                FiguraGeometrica f = new FiguraGeometrica("", nr);

                Console.WriteLine($"Nr laturi: {nr} -> {f.TipFigura}");
            }

            Console.WriteLine("Introdu numarul de laturi al figurii:");
            int nrLatJ = int.Parse(Console.ReadLine());

            FiguraGeometrica figura = new FiguraGeometrica("", nrLatJ);
            Console.WriteLine($"Figura cu {nrLatJ} laturi este: {figura.TipFigura}");
            Console.ReadKey();
        }
    }

}