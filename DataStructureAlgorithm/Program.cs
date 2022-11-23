namespace DataStructureAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("select option\n 1.Binary Search \n 2.InsertionSort");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.ReadTextFile(@"C:\\Bridgelabz\\Assignments\\Day16-17\\AlgorithmPrograms\\DataStructureAlgorithm\\BinarySearch.txt");
                        binarySearch.BinarySearchOperation("Hello, Welcome, To, Coding");
                        break;

                        case 2:
                        int[] arr = { 1,5,7,4,8,4,8,3 };
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.Sort(arr);
                        break;
                }
            }
        }
    }
}