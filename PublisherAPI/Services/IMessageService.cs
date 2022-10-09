namespace PublisherAPI.Services
{
    public interface IMessageService
    {
        bool Enqueue(string message);
    }
}
