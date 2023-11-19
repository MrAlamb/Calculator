using UnityEngine;
using TMPro;

public class PointSetting : MonoBehaviour
{
    public TMP_Text result;
    public void OnClick()
    {

        if (int.TryParse(result.text, out _))
        {
            result.text += '.';
        }
        }

}
