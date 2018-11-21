using System;

namespace Utils
{
    public abstract class ScenarioBase
    {
        protected abstract void Setup();
        protected abstract void Run();
        protected abstract void Cleanup();

        public void Execute()
        {
            try
            {
                Setup();
                Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Cleanup();
            }
        }
    }
}