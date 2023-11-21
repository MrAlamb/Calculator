using UnityEngine;
using TMPro;

public class PointSetting : MonoBehaviour
{
    public void OnClick()
    {

        if (int.TryParse(Variables.SharedInstance.result.text, out _))
        {
            Variables.SharedInstance.result.text += '.';
        }
        }

}
