using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlusMinusSettings : FunctionsAndVariables
{
    public void OnClick()
    {
        string v = (0 - double.Parse(result.text)).ToString();
        result.text = v;
    }
}
