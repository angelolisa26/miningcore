using Miningcore.Crypto;
using Miningcore.Crypto.Hashing.Algorithms;

namespace Miningcore.Blockchain.Kaspa.Custom.Nexellia;

public class NexelliaJob : KaspaJob
{
    public NexelliaJob()
    {
        this.coinbaseHasher = new Blake3();
    }
}