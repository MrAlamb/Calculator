using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultiplySettings : FunctionsAndVariables
{
    public void OnClick()
    {
        FourthValue = double.Parse(result.text);

        operation = EnumOperation.Multiply;
      Do();
        result.text = "";

    }
}
