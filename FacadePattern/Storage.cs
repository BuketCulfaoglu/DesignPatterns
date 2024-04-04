namespace FacadePattern
{
    internal class Storage : IStorage
    {
        public void Read()
        {
            Console.WriteLine("Storage reading data...");
        }

        public void Write()
        {
            Console.WriteLine("Storage writing data...");
        }
    }
}
