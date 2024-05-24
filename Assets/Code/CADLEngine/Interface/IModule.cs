namespace CADLEngine
{
    public interface IModule
    {
        public ILinks Links { get; }
        public IData Data { get; }
        public IActions Actions { get; }
        
    }
}