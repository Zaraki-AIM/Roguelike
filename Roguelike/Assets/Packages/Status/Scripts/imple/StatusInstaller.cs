using UnityEngine;
using Zenject;
using Status.Messaging;

namespace Status.Messaging
{
  public class StatusInstaller : MonoInstaller
  {
    public override void InstallBindings()
    {
      Container.Bind<StatusMessageBroker>().To<StatusMessageBroker>().AsSingle();
    }
  }
}