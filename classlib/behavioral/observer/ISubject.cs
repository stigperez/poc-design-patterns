using System.Collections.Generic;

namespace classlib.behavioral.observer
{
    public interface ISubject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        List<bool> Notify();
    }
}