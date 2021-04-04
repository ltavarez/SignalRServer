using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SelfHosted
{
    [HubName("TestHub")]
    public class MyHub : Hub
    {
        public void Notify(string info)
        {
            Clients.All.SendInfo(info);
        }

        public void Notify2(bool notify)
        {
            Clients.All.SendNotify(notify);
        }
    }
}
