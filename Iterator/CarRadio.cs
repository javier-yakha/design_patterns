using System;
using System.Threading.Channels;

namespace Iterator
{
    public class CarRadio : IChannelCollection
    {
        private List<Channel> channels;

        public CarRadio()
        {
            this.channels = new List<Channel>();
        }

        public void AddChannel(Channel c)
        {
            channels.Add(c);
        }

        public IChannelIterator CreateIterator()
        {
            return new ChannelIteratorNormal(channels);
        }
        public IChannelIterator CreateShuffleIterator()
        {
            return new ChannelIteratorShuffle(channels);
        }

        public void RemoveChannel(Channel c)
        {
            channels.Remove(c);
        }
    }
}

