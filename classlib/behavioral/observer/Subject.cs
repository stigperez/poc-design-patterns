using System.Collections.Generic;

namespace classlib.behavioral.observer
{
    public abstract class Subject : ISubject
    {
        public List<Observer> _observers = new List<Observer>();
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }
        public List<bool> Notify()
        {
            var notifications = new List<bool>(_observers.Count);
            _observers.ForEach(observer => notifications.Add(observer.Update()));
            return notifications;
        }
    }
}