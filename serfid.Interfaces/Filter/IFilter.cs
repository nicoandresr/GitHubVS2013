using serfid.Interfaces.Enumerations;

namespace serfid.Interfaces.Filter
{
    public interface IFilter
    {
        ModuleStatus Start();
        FilterResult Tramit(string reading);
    }
}