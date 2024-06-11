namespace Which_are_in
{
    internal class Program
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j].Contains(array1[i]))
                    {
                        result.Add(array1[i]);
                        break;
                    }
                }
            }

            result.Sort();

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };

            foreach (string item in inArray(a1, a2))
            {
                Console.WriteLine(item);
            }
        }
    }
}