using System;

namespace Foundation4
{
    class Program
    {
        static void Main(string[] args)
        {
            var activities = new Activity[]
            {
                new Running(new DateTime(2023, 7, 17), 30, 3),
                new Cycling(new DateTime(2023, 7, 17), 30, 6),
                new Swimming(new DateTime(2023, 7, 17), 30, 96)
            };

            foreach (var acitvity in activities)
            {
                string summary = acitvity.GetSummary();
                Console.WriteLine(summary);
            }

        }
    }
}
