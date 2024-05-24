namespace CADLEngine
{
    public interface IExecute : IAction
    {
        public void Execute(float deltaTime);
    }
}