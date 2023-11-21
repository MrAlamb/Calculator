using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ACSettings : MonoBehaviour
{

    public void OnClick()
    {
        Variables.SharedInstance.SecondValue = 0.0;
        Variables.SharedInstance.SecondValueBool = true;
        Variables.SharedInstance.DivMultiplyOperation = false;
        Variables.SharedInstance.ThirdValue = 1;
        Variables.SharedInstance.LastValue = 0;
        Variables.SharedInstance.stackOperation.Clear();
        Variables.SharedInstance.result.text = "";
    }
}
