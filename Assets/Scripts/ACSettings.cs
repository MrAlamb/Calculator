using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ACSettings : FunctionsAndVariables
{
    public TMP_Text result;

    public void OnClick()
    {
       SecondValue = 0.0;
       SecondValueBool = true;
       k = false;
       ThirdValue = 1;
       FourthValue = 0.0;
       stackOperation.Clear();
        result.text = "";
}
}
