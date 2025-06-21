namespace AssignmentC_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declare Variable
            int x = 5; // value type
            Console.WriteLine($"X = {5}");
            
            string y = "Hello"; // reference type
            Console.WriteLine($"Y = {y}");
            #endregion


            #region System.Object

            object obj = 5;
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine(obj.ToString()); 
            Console.WriteLine(obj.GetType()); 
            Console.WriteLine(obj.Equals(5)); 


            #endregion
        }
    }
}
