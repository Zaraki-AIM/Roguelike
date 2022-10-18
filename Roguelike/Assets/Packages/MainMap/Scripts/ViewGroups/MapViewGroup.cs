using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainMap{
  public class MapViewGroup : MonoBehaviour
  {
    [SerializeField]
    GameObject _WallPrefab;

    [SerializeField]
    GameObject _RoomPrefab;

    [SerializeField]
    GameObject _AislePrefab;

    public void SetMap(GameObject parentObject, EnumDefine.MainMapType mainMapType)
    {
      switch (mainMapType)
      {
        case EnumDefine.MainMapType.Wall:
          Instantiate(_WallPrefab,parentObject.transform);
          break;
        case EnumDefine.MainMapType.Room:
          Instantiate(_RoomPrefab,parentObject.transform);
          break;
        case EnumDefine.MainMapType.Aisle:
          Instantiate(_AislePrefab,parentObject.transform);
          break;
        default:
          break;
      }
    }
  }

}
