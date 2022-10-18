using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

public class BootSceneController : MonoBehaviour
{
    void Start()
    {
        SceneNavigator.ChangeScene(SceneNameDefine.Title);
    }
}
