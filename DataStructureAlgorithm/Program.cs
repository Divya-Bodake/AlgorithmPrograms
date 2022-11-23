namespace DataStructureAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("select option\n 1.Binary Search");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.ReadTextFile(@"C:\\Bridgelabz\\Assignments\\Day16-17\\AlgorithmPrograms\\DataStructureAlgorithm\\BinarySearch.txt");
                        binarySearch.BinarySearchOperation("Hello, Welcome, To, Coding");
                        break;
                }
            }
        }
    }
}