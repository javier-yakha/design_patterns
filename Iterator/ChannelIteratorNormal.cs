using System;
using System.Threading.Channels;

namespace Iterator
{
    public class ChannelIteratorNormal : IChannelIterator
    {
        private List<Channel> channels;
        private int currentPosition = 0;

        public ChannelIteratorNormal(List<Channel> channels) //constru
        {
            this.channels = channels;
        }

        public bool HasNext()
        {
            return currentPosition < channels.Count;
        }

        public Channel Next()
        {
            return channels[currentPosition++]; 
        }
    }
}

