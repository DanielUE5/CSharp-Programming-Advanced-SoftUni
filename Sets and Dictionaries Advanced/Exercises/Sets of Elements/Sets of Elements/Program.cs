class SetsOfElements
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        HashSet<int> setN = new HashSet<int>();

        HashSet<int> setM = new HashSet<int>();

        List<int> listN = new List<int>();  

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            listN.Add(num);  
            setN.Add(num);  
        }

        for (int i = 0; i < m; i++)
        {
            int num = int.Parse(Console.ReadLine());
            setM.Add(num);  
        }

        List<int> commonElements = new List<int>();
        foreach (int num in listN)  
        {
            if (setM.Contains(num) && !commonElements.Contains(num))  
            {
                commonElements.Add(num);
            }
        }

        if (commonElements.Count > 0)
        {
            Console.WriteLine(string.Join(" ", commonElements));
        }
    }
}
