namespace GenericScale
{
    public class StartUp
    {
        public static void Main()
        {
            EqualityScale<int> scale1 = new EqualityScale<int>(5, 5);
            Console.WriteLine(scale1.AreEqual()); // Output: True

            EqualityScale<int> scale2 = new EqualityScale<int>(3, 5);
            Console.WriteLine(scale2.AreEqual()); // Output: False
        }
    }
}

