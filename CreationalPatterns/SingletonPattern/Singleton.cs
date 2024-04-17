namespace SingletonPattern
{
    internal abstract class Singleton
    {
        protected string _name;

        public virtual void PrintName()
        {
            Console.WriteLine(_name);
        }        
        
        public virtual string GetName()
        {
            return _name;
        }
    }
}
