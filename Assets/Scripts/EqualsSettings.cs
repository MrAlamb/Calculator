using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EqualsSettings : FunctionsAndVariables
{
   // private FunctionsAndVariables a;

    public void OnClick()
    {
        FourthValue = double.Parse(result.text);

        operation = EnumOperation.Equals;
        Do();
        result.text = SecondValue.ToString();
    } 
}
 