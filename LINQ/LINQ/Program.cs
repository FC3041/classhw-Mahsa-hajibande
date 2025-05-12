namespace LINQ;

class Program
{
    static void Main(string[] args)
    {
        var data = File.ReadAllLines("data.csv")
            .Skip(1)
            .Select (c =>
            {
                string [] tokens = c.Split (',') ;
                double year = double.Parse (tokens [5]) ;
                string country = tokens [3];
                string gender = tokens [4];
                string indicator = tokens [0];
                double life_expectancy = double.Parse(tokens [6]);
                return (country: country , year: year , gender: gender , life_expectancy: life_expectancy , indicator: indicator);
            })
            .Where (c => c.country.Contains("Iran"))    
            .Where (c => c.gender == "Both")
            .Where (c => c.indicator.Contains ("at birth"))
            .OrderBy (c => c.life_expectancy)     
            .ToList();
            //var results = data
            //.GroupBy (c => c.country)
            //.Select (c =>
            //{
            //    var min = c.Min (x => x.life_expectancy) ;
            //    var max = c.Max (x => x.life_expectancy) ;
            //    var minRecord = c.First(x => x.life_expectancy == min) ;
            //    
            //    return new
            //        {
            //            Country = c.Key,
            //            WorstYear = minRecord.year,
            //            WorstLifeExpectancy = min,
            //            Improvement = max - min
            //        };
            //})
            //.OrderByDescending(x => x.Improvement)
            
            //.ToList() ;
            data.ForEach(c => Console.WriteLine(c));
            if (data.Any())
            {
                double min = data.Min(c => c.life_expectancy);
                double max = data.Max(c => c.life_expectancy);
                double diff = max - min;

                Console.WriteLine("\nLife Expectancy Analysis for Iran:");
                Console.WriteLine($"Minimum: {min} years");
                Console.WriteLine($"Maximum: {max} years");
                Console.WriteLine($"Difference: {diff} years");
            }
    }
}
