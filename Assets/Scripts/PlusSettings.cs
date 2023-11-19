using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlusSettings : FunctionsAndVariables
{
   // private FunctionsAndVariables a;
   
    public void OnClick()
    {
        FourthValue = double.Parse(result.text);

        operation = EnumOperation.Plus;
        Do();
        result.text = "";
    }
}
