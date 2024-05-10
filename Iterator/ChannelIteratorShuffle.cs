namespace Iterator;

public class ChannelIteratorShuffle : IChannelIterator
{
    private List<Channel> channels;
    public ChannelIteratorShuffle(List<Channel> channels)
    {
        this.channels = channels;
    }
    public bool HasNext()
    {
        return true;
    }
    public Channel Next()
    {
        Random r = new Random();
        int randomIndex = r.Next(channels.Count);
        return channels[randomIndex];
    }
}
