using Ninject.Modules;
using serfid.DataAccess.SqlServerEF;
using serfid.InfraestructureCore.ReadingTranslators;
using serfid.Interfaces.DataAccess;
using serfid.Interfaces.Filter;
using serfid.Interfaces.Infraestructure;
using serfid.Interfaces.Listener;
using serfid.Interfaces.Storage;
using serfid.Interfaces.User;

namespace serfid.MainModule
{
    public class InjectionModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IListener>().To<Listener.Listener>();
            Bind<ITranslator>().To<TranslatorBase64>();
            Bind<IFilter>().To<Filter.FilterPrototipeProtocol>();
            Bind<IStorage>().To<Storage.Storage>();
            Bind<ISerfidDataAccess>().To<SerfidDataAccess>();
            Bind<IUser>().To<User.User>();
            Bind<SerfidCore>().ToSelf();
        }
    }
}
