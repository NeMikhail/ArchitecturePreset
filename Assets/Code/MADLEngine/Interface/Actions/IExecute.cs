namespace MADLEngine
{
    public interface IExecute : IAction
    {
        public void Execute(float deltaTime);
    }
}