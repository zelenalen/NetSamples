namespace NetSamples.Generics;

public class MessageSender<T> where T : Message
{
    public void SendMessage<TY>(T message, TY to) where TY : DestinationAddress
    {
        Console.WriteLine($"Message {message.Text} was sent to {to.Email}");
    }
}

//generic type limitation variants:
// where T :
// - ConcreteClass
// - ConcreteInterface
// - class(any class)
// - struct(any struct)
// - new() -> any type with public constructor w\o parameters 
// we can use more then one limitation