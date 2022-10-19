using UnityEngine;
using UnityEngine.UI;

namespace Common
{
  public class CommonTextView : MonoBehaviour
  {
      [SerializeField]
      protected Text _Text;

      public void SetText(string targetText)
      {
          _Text.text = targetText;
      }
  }
}
