using serfid.Interfaces.Enumerations;

namespace serfid.Interfaces.Listener
{
    public interface IListener
    {
        ModuleStatus Start();
        ReadingResult Read(string reading);
    }
}