using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfChatService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(ICallBackIService1))]
    public interface IService1
    {
        [OperationContract(IsOneWay = true)]
        void SendMessage(string name,string message);
        [OperationContract(IsOneWay = true)]
        void Connect(string name);
        [OperationContract(IsOneWay = false)]
        bool Disconnect(string name);

        void Channel_Faulted(object sender, EventArgs e);
        void Logout(IContextChannel channel);
    }



    public interface ICallBackIService1
    {
        [OperationContract(IsOneWay = true)]
        void Updatestatus(string status);
        [OperationContract(IsOneWay = true)]
        void GetMessage(string message);
    }

}
