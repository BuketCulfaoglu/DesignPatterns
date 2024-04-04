namespace FacadePattern
{
    internal class ComputerFacade
    {
        private ICPU cpu;
        private IMemory memory;
        private IStorage storage;

        public ComputerFacade()
        {
            cpu = new CPU();
            memory = new Memory();
            storage = new Storage();
        }

        public void Start()
        {
            cpu.Execute();
            memory.Load();
            storage.Read();
        }

        public void Stop()
        {
            storage.Write();
        }
    }
}
