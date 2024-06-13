namespace MADLEngine
{
    public interface IFixedExecute : IAction
    {
        public void FixedExecute(float fixedDeltaTime);
    }
}