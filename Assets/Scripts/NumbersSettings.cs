using System.Collections;
using System.Collections.Generic;
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

}
