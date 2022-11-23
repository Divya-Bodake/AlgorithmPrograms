namespace DataStructureAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("select option\n 1.Binary Search \n 2.InsertionSort\n 3.BubbleSort\n 4.Anagram \n 5.UserInput\n 6.Unordered List");
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

                    case 3:
                        BubbleSort bubbleSort = new BubbleSort();
                        int[] binaryarr = {5, 2, 1, 4, 3};
                        bubbleSort.Sort(binaryarr);
                        break;
                    case 4:
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram("heart", "earth");
                        break;
                    case 5:
                        UserInput input = new UserInput();
                        input.ReplaceString();
                        break;
                    case 6:
                        LinkedListGeneric<string> linkedListGeneric = new LinkedListGeneric<string>();
                        linkedListGeneric.Add("Divya");

                        linkedListGeneric.Display();
                        break;
                }
            }
        }
    }
}