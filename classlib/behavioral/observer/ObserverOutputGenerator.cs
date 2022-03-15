using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classlib.behavioral.observer
{
    public class ObserverOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            var subject = new StockSubject();
            subject.Attach(new CompanyObserver(subject) {Name = "IBM"});
            subject.Attach(new CompanyObserver(subject) {Name = "GM"});
            subject.Attach(new CompanyObserver(subject) {Name = "Google"});
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Stock value before change: {subject.Value}");
            subject.Value += 10;
            var notifications = subject.Notify();
            stringBuilder.AppendLine($"Stock value after change: {subject.Value}, observers successfully notified: {notifications.Count(notification => notification)}/{notifications.Count}");
            return stringBuilder.ToString();
        }
    }
}