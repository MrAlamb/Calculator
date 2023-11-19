using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MinusSetting : FunctionsAndVariables
{
  // private FunctionsAndVariables a;
    public void OnClick()
    {
        FourthValue = double.Parse(result.text);

        operation = EnumOperation.Minus;
        Do();
        result.text = "";
    }
}
