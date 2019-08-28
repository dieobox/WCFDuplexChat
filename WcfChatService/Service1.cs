using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfChatService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        private List<Tuple<string, IContextChannel, ICallBackIService1>> Channels = new List<Tuple<string, IContextChannel, ICallBackIService1>>();

        public void Connect(string name)
        {
            ICallBackIService1 Callbackchannel = OperationContext.Current.GetCallbackChannel<ICallBackIService1>();
            IContextChannel channel = OperationContext.Current.Channel;
            channel.Faulted += new EventHandler(Channel_Faulted);
            channel.Closed += new EventHandler(Channel_Faulted);

            if (Channels.Where(a => a.Item1 == name).Count() == 0)
            {
                Channels.Add(new Tuple<string, IContextChannel, ICallBackIService1>(name, channel, Callbackchannel));
              //  Callbackchannel.Updatestatus("A user with name '" + name + "' Connected .\r\n");

                foreach (var ch in Channels)
                {
                    ch.Item3.GetMessage(name + " join" + "\r\n");
                }
                //  return true;
            }
            else
            {
                Callbackchannel.Updatestatus("A user with name '"+name+ "' already exists.\r\n");
               // return false;
            }
        }

        public bool Disconnect(string name)
        {
          var con = Channels.Where(a => a.Item1 == name).FirstOrDefault();
          Logout(con.Item2);
            return true;
        }

        public void SendMessage(string name, string message)
        {
            foreach (var channel in Channels)
            {
                channel.Item3.GetMessage(name + ":" + message+ "\r\n");
            }
        }

        public void Channel_Faulted(object sender, EventArgs e)
        {
            Logout((IContextChannel)sender);
        }

        public void Logout(IContextChannel contextchannel)
        {

            var removechannel = Channels.Where(a => a.Item2 == contextchannel).FirstOrDefault();
            if (removechannel != null)
            {
                var name = removechannel.Item1;
                Channels.Remove(removechannel);
                foreach (var channel in Channels)
                {
                    channel.Item3.GetMessage(name + " exit" + "\r\n");
                }
            }

        }


    }
}
