namespace CompositePattern
{
    internal class Directory : IFileSystemComponent
    {
        private List<IFileSystemComponent> fileSystemComponents = new List<IFileSystemComponent>();

        public int GetSize()
        {
            int size = 0;

            foreach (IFileSystemComponent fileSystemComponent in fileSystemComponents)
            {
                size += fileSystemComponent.GetSize();
            }

            return size;
        }

        public void AddComponent(IFileSystemComponent fileSystemComponent)
        {
            fileSystemComponents.Add(fileSystemComponent);
        }

        public void RemoveComponent(IFileSystemComponent fileSystemComponent)
        {
            fileSystemComponents.Remove(fileSystemComponent);
        }
    }
}
