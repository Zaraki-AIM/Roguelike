using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Common
{
  public class SceneNavigator : MonoBehaviour
  {
    private string _currentSceneName = "";
    public string CurrentSceneName { get { return _currentSceneName; } }

    private string _beforeSceneName = "";
    public string BeforeSceneName { get { return _beforeSceneName; } }

    private string _nextSceneName = "";
    public string NextSceneName { get { return _nextSceneName; } }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static void ChangeScene(string sceneName)
    {
      SceneManager.LoadScene(sceneName);
    }
  }
}
