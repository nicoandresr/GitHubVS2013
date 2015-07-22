using Ninject.Modules;
using serfid.Interfaces.Listener;
using serfid.Interfaces.MainModule;
using serfid.Listener;

namespace serfid.MainModule
{
    public class InjectionModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IListener>().To<Listener.Listener>();
            Bind<Serfid>()
        }
    }
}
