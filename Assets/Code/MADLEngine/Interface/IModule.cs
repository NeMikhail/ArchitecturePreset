namespace MADLEngine
{
    public interface IModule
    {
        public ILinks Links { get; set; }
        public IData Data { get; }
        public IActions Actions { get; }
        
    }
}