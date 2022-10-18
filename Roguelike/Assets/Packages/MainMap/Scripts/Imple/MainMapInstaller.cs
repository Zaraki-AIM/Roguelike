using UnityEngine;
using Zenject;
using MainMap;

public class MainMapInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
      // Container.Bind<MainMapService>().AsSingle();
    }
}