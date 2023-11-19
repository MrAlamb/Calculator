using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DivideSettings : FunctionsAndVariables
{
   // private FunctionsAndVariables a;

    public void OnClick()
    {
        FourthValue = double.Parse(result.text);

        operation = EnumOperation.Div;
        Do();
        result.text = "";

    }
}
