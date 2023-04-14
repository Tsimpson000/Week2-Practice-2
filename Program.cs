namespace Week2_Practice_2
{
    internal class Program
    {
        static List<Student> _classRoster;
        static void Main(string[] args)
        {
            _classRoster = new List<Student>();
            Instructor will = new Instructor("Will", "Cram");
            SchoolProgram prog124 = new SchoolProgram("Programming", "124", "J102", will);
            Student tyler = new Student("Tyler", "Simpson", 100, 80);
            Student shiva = new Student("Shiva", "Kitty", 120, 100);
            Student fluffy = new Student("Fluffy", "Cat", 110, 110);
            _classRoster.Add(tyler);
            _classRoster.Add(shiva);
            _classRoster.Add(fluffy);

            Console.WriteLine(prog124.ToString());
            Console.WriteLine($"Instructor: {will}");
            for (int i = 0; i < _classRoster.Count; i++)
            {
                Console.WriteLine($"{_classRoster[i].ToString()}");
            }
        }
    }
}