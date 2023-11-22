using System.Xml.Linq;

internal class Program
{
    // Create a data source by using a collection initializer.
    static List<City> cities = new List<City>
    {
        new City {First="Svetlana", Last="Omelchenko", ID=111, Population= 60.000},
        new City {First="Claire", Last="O'Donnell", ID=112, Population= 390},
        new City {First="Sven", Last="Mortensen", ID=113, Population= 91.000},
        new City {First="Cesar", Last="Garcia", ID=114, Population= 820},
        new City {First="Debra", Last="Garcia", ID=115, Population= 70.000},
        new City {First="Fadi", Last="Fakhouri", ID=116, Population= 940},
        new City {First="Hanying", Last="Feng", ID=117, Population= 870},
        new City {First="Hugo", Last="Garcia", ID=118, Population= 780},
        new City {First="Lance", Last="Tucker", ID=119, Population= 92.000},
        new City {First="Terry", Last="Adams", ID=120, Population= 790},
        new City {First="Eugene", Last="Zabokritski", ID=121, Population= 60.000},
        new City {First="Michael", Last="Tucker", ID=122, Population= 910}
    };
    private static void Main(string[] args)
    {
        /* IEnumerable<Student> studentquery =
                    from student in students
                    where student.Scores[0] > 90 && student.Scores[3] < 80
                    orderby student.Last descending
                    orderby student.Scores[0] descending
                    select student;
        foreach (Student item in studentquery)
        {
            Console.WriteLine($"{item.Last}, {item.First}, {item.Scores[0]}");
        } */
        // int[] scores = { 10, 50, 90, 97, 76, 89, 80 };
        /* var query = from num in numbers
                    where (num % 2) == 0
                    select num;
        int queryCount = query.Count();
        Console.Write(queryCount); // Me muestra la ejecucuion de "where" seria que me mustra los numeros multiplos de "2".
        foreach (int num in numbers)
        {
            Console.Write(" {0,1}",num); // Me muestra la secuencia del Array que tengo.
        } */
        /* List<int> numquery2 = (from num in numbers
                               where (num % 2) == 0
                               select num).ToList();
        foreach (int item in numquery2)
        {
            Console.WriteLine("{0,1}", item);
        } */
        /* var numquery3 = (from num in numbers
                                where (num % 2) == 0
                                select num).ToArray();
        foreach (int num in numquery3)
        {
            Console.WriteLine("{0,1}",num);
        } */
        /* IEnumerable<int> highScoresQuery = from score in scores
                                                where score > 80
                                                orderby score descending
                                                select score;
        foreach (int item in highScoresQuery)
        {
            Console.WriteLine("{0,1}",item);
        } */
        /* IEnumerable<string> highScoresQuery2 = from score in scores
                                                where score > 80
                                                orderby score descending
                                                select $"The score is {score}";
        foreach (string item in highScoresQuery2)
        {
            Console.WriteLine(item);
        } */
        /* IEnumerable<int> highScoresQuery3 = from score in scores
                                                where score > 80
                                                select score;
        int scoreCount = highScoresQuery3.Count();
        Console.WriteLine($"The Count is: {scoreCount}");
        foreach (int item in highScoresQuery3)
        {
            Console.WriteLine(item);
        } */
        //Query syntax
        IEnumerable<City> queryMajorCities =
            from city in cities
            where city.Population > 100000
            select city;
        foreach (var item in queryMajorCities)
        {
            Console.WriteLine($"the datas in City: {queryMajorCities}");
        }
        // Method-based syntax
        // IEnumerable<City> queryMajorCities2 = cities.Where(c => c.Population > 100000);
    }

    public class City
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public double Population;
    }
}

