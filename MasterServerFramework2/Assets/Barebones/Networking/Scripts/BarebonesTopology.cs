using ConnectionConfig = UnityEngine.Networking.ConnectionConfig;
using HostTopology = UnityEngine.Networking.HostTopology;
using Mirror;

namespace Barebones.Networking
{
    public class BarebonesTopology
    {
        static BarebonesTopology()
        {
            var config = new ConnectionConfig();
            ReliableChannel = config.AddChannel(QosType.Reliable);
            UnreliableChannel = config.AddChannel(QosType.Unreliable);
            ReliableSequencedChannel = config.AddChannel(QosType.ReliableSequenced);

            Topology = new HostTopology(config, 5000);
        }

        public static HostTopology Topology { get; private set; }

        public static int ReliableChannel { get; private set; }
        public static int UnreliableChannel { get; private set; }
        public static int ReliableSequencedChannel { get; private set; }
    }
}