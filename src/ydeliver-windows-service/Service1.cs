using System.ServiceProcess;

namespace ydeliver_windows_service
{
    public partial class ydeliver : ServiceBase
    {
        public ydeliver()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("YDeliverSource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "YDeliverSource", "YDeliverLog");
            }
            eventLog1.Source = "YDeliverSource";
            eventLog1.Log = "YDeliverLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In OnStart");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In onStop.");
        }
    }
}
