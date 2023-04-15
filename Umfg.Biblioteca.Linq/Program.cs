namespace Umfg.Biblioteca.Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>()
            {
                "Pedro",
                "Felipe",
                "Luis",
            };

            lista.Add("Fabricio");
            lista.AddRange(lista);
            lista.AddRange(new List<string>()
            {
                "Fanti",
                "Dias",
            });

            Console.WriteLine("for");
            for (var i = 0; i < lista.Count; i++)
                Console.WriteLine(lista[i]);

            Console.WriteLine("foreach");
            foreach (var nome in lista)
                Console.WriteLine(nome);

            Console.WriteLine("ForEach | LINQ");
            lista.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Obter o primeio registro");
            Console.WriteLine(lista[0]);

            Console.WriteLine("Obter o primeio registro | LINQ");
            Console.WriteLine(lista.FirstOrDefault());

            Console.WriteLine("Obter o primeio registro | LINQ com filtro");
            Console.WriteLine(lista.FirstOrDefault(x => x == "Luis"));

            Console.WriteLine("Obter o ultimo registro | LINQ");
            Console.WriteLine(lista.LastOrDefault());

            Console.WriteLine("Obter o primeio registro | LINQ com filtro");
            Console.WriteLine(lista.LastOrDefault(x => x == "Fanti"));

            Console.WriteLine("foreach com filtro | LINQ");
            foreach (var nome in lista.Where(x => x == "Pedro"))
                Console.WriteLine(nome);

            #region errado

            lista
                .Where(x => x == "Pedro")
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            #endregion errado
        }
    }
}