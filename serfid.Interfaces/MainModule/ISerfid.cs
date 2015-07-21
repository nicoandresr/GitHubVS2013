using serfid.Interfaces.Listener;

namespace serfid.Interfaces.MainModule
{
    public interface ISerfid
    {
        void AppStart();
        void ReadWeft(string reading);
    }
}