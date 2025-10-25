class SimpleTextEditor
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); 
        string text = ""; 
        Stack<(string, string)> history = new Stack<(string, string)>(); 

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int command = int.Parse(input[0]);

            switch (command)
            {
                case 1: 
                    string appendString = input[1];
                    history.Push((text, "1")); 
                    text += appendString; 
                    break;

                case 2: 
                    int count = int.Parse(input[1]);
                    history.Push((text.Substring(text.Length - count), "2")); 
                    text = text.Length > count ? text.Substring(0, text.Length - count) : ""; 
                    break;

                case 3: 
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                    break;

                case 4: 
                    if (history.Count > 0)
                    {
                        var lastAction = history.Pop(); 
                        string lastText = lastAction.Item1; 
                        string operationType = lastAction.Item2;

                        if (operationType == "1") 
                        {
                            text = lastText; 
                        }
                        else if (operationType == "2") 
                        {
                            text += lastText; 
                        }
                    }
                    break;
            }
        }
    }
}
