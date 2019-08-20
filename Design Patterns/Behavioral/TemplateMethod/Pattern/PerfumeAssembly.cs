namespace TemplateMethod
{
    abstract class PerfumeAssembly
    {
        public void Assembly()
        {
            CreateBottle();
            CreatePerfumeWater();
            CreateCaps();
            PouringPerfumeAndCloseCaps();
        }

        protected abstract void CreateBottle();
        protected abstract void CreatePerfumeWater();
        protected abstract void CreateCaps();
        protected abstract void PouringPerfumeAndCloseCaps();
    }
}
