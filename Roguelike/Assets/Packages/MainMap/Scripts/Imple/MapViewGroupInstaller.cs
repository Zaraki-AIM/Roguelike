using UnityEngine;
using Zenject;
using MainMap;

public class MapViewGroupInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
      Container.Bind<MapViewGroup>().AsSingle();
    }
}