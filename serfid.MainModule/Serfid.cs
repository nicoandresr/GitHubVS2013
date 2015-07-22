using Ninject;

namespace serfid.MainModule
{
    public class Serfid
    {
        private SerfidCore _serfidCore;

        public Serfid()
        {
            IKernel kernel = new StandardKernel(new InjectionModule());
            _serfidCore = kernel.Get<SerfidCore>();
        }

        public void Run()
        {
            
            _serfidCore.AppStart();
        }

        public void ReadWeft(string reading)
        {
            _serfidCore.ReadWeft(reading);
        }
    }
}