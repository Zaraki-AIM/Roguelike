using TypedMessageBroker;
namespace Status.Messaging{
  public interface IStatusEventType { }
  public class StatusMessageBroker : TypedMessageBroker<IStatusEventType> { }
}
