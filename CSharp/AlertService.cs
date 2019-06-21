using System;
using System.Collections.Generic;

namespace InterviewQuestions.CSharp
{
    public class AlertService
    {
        private readonly IAlertDAO _storage;

        public AlertService(IAlertDAO storage)
        {
            _storage = storage;
        }

        public Guid RaiseAlert()
        {
            return _storage.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return _storage.GetAlert(id);
        }
    }

    public interface IAlertDAO
    {
        Guid AddAlert(DateTime time);

        DateTime GetAlert(Guid id);
    }

    public class AlertDAO : IAlertDAO
    {
        private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

        public Guid AddAlert(DateTime time)
        {
            Guid id = Guid.NewGuid();
            this.alerts.Add(id, time);
            return id;
        }

        public DateTime GetAlert(Guid id)
        {
            return this.alerts[id];
        }
    }
}
