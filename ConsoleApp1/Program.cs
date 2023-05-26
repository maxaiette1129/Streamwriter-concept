namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("path/to/file.txt"))
            {

                string name = "Maxaiette";
                int id = 1231241254;
                writer.WriteLine($"Hello, World! {name} {id}");

                writer.WriteLine("This is an example of StreamWriter.");

                // You can also use the Write method to write without a line terminator
                writer.Write("This ");
                writer.Write("is ");
                writer.Write("a ");
                writer.Write("single ");
                writer.Write("line.");

                // Flush the buffer to ensure all data is written to the file
                writer.Flush();

                // Close the StreamWriter (this will also flush any remaining data)
                writer.Close();
            }
        }
    }
}