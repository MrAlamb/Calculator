using UnityEngine;
using TMPro;

public class NumbersSettings : MonoBehaviour
{

    public TMP_Text result;
    public TMP_Text TEXT;

    public void OnClick()
    {
        result.text += TEXT.text;
    }

    public void Update()
    {
        if (Input.inputString == TEXT.text)
        {
            result.text += TEXT.text;
        }
    }

}
