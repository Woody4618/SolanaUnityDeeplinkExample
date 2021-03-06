// ReSharper disable ClassNeverInstantiated.Global

namespace Solnet.Rpc.Models
{
    /// <summary>
    /// Represents a node in the cluster.
    /// </summary>
    public class ClusterNode
    {
        /// <summary>
        /// Gossip network address for the node.
        /// </summary>
        public string Gossip { get; set; }

        /// <summary>
        /// A base-58 encoded public key associated with the node.
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// JSON RPC network address for the node. The service may not be enabled.
        /// </summary>
        public string Rpc { get; set; }

        /// <summary>
        /// TPU network address for the node.
        /// </summary>
        public string Tpu { get; set; }

        /// <summary>
        /// The software version of the node. The information may not be available.
        /// </summary>
        public string Version { get; set; }

        public ulong? FeatureSet { get; set; }
        public ulong ShredVersion { get; set; }
    }
}