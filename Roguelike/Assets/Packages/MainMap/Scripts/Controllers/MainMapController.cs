using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainMap;
using Zenject;

public class MainMapController : MonoBehaviour
{
  //[Inject]
  //private MainMapService _MainMapService;
  [Inject]
  private MapViewGroup _MapViewGroup;
  [SerializeField]
  private GameObject _MapCreatedArea;

  private void Start()
  {
    _MapViewGroup.SetMap(_MapCreatedArea,EnumDefine.MainMapType.Wall);
  }
}
