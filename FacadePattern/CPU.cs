namespace FacadePattern
{
    internal class CPU : ICPU
    {
        public void Execute()
        {
            Console.WriteLine("CPU executing instructions...");
        }
    }
}
