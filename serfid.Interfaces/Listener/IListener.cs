using serfid.Interfaces.Enumerations;

namespace serfid.Interfaces.Listener
{
    public interface IListener
    {
        ModuleStatus start();
        ReadingResult Read(string reading);
    }
}