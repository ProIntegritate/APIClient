// Test variable: SGVsbG8gd29ybGQhIA0K == Hello world in base64

using System;

namespace APIClient_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sPassedArgs = ""; 
            try
            {
                sPassedArgs = System.Text.Encoding.Default.GetString(Convert.FromBase64String(args[0])); // Convert from B64 -> String
            }
            catch { // Do nothing, fail silently if Base64 decoding fails
            }

            if (sPassedArgs != "") Console.WriteLine("Passed arguments was: " + sPassedArgs);

            DateTime d = DateTime.UtcNow;
            Console.WriteLine("Execution finished at: " + d.ToString("G"));

            Environment.Exit(0); // Return zero as status to external programs

        }
    }
}
