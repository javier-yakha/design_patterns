namespace Iterator;

public class ChannelIteratorShuffle : IChannelIterator
{
    private List<Channel> channels;
    private int currentPosition = 0;
    public ChannelIteratorShuffle(List<Channel> channels)
    {
        Random r = new Random();
        // Fisher-Yates Shuffle
        for (int i = channels.Count - 1; i > 0; i--)
        {
            int j = r.Next(0, i + 1);
            // Tuple swap
            (channels[i], channels[j]) = (channels[j], channels[i]);
        }
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
