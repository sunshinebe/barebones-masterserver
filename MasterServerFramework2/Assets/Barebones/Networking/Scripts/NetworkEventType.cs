using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mirror
{
    //
    // 摘要:
    //     Event that is returned when calling the Networking.NetworkTransport.Receive and
    //     Networking.NetworkTransport.ReceiveFromHost functions.
    public enum NetworkEventType
    {
        //
        // 摘要:
        //     Data event received. Indicating that data was received.
        DataEvent = 0,
        //
        // 摘要:
        //     Connection event received. Indicating that a new connection was established.
        ConnectEvent = 1,
        //
        // 摘要:
        //     Disconnection event received.
        DisconnectEvent = 2,
        //
        // 摘要:
        //     No new event was received.
        Nothing = 3,
        //
        // 摘要:
        //     Broadcast discovery event received. To obtain sender connection info and possible
        //     complimentary message from them, call Networking.NetworkTransport.GetBroadcastConnectionInfo()
        //     and Networking.NetworkTransport.GetBroadcastConnectionMessage() functions.
        BroadcastEvent = 4
    }
}
