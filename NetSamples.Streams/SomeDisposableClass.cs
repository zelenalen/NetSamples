namespace NetSamples.Streams;

public class SomeDisposableClass : IDisposable
{
    public void OpenConnection()
    {

    }

    public void CloseConnection()
    {

    }
    public void Dispose()
    {
        CloseConnection();
        //todo implement closing all necessary connection
        //clear unmanaged resources
    }
}