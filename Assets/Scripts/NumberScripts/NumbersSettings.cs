using UnityEngine;
using TMPro;

public class NumbersSettings : MonoBehaviour
{
    public TMP_Text TEXT;

    public void OnClick()
    {
        Variables.SharedInstance.result.text += TEXT.text;
    }

    public void Update()
    {
        if (Input.inputString == TEXT.text)
        {
            Variables.SharedInstance.result.text += TEXT.text;
        }
    }

}
