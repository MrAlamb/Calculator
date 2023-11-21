using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class Variables : MonoBehaviour
{
   private static Variables instance = null; public static Variables SharedInstance
    {
        get
        {
            if (instance == null)
            {
                GameObject variablesObject = GameObject.FindWithTag("Variables");
                instance = variablesObject.GetComponent<Variables>();
            }
            return instance;
        }
    }

    public enum EnumOperation
    {
        Div, Plus, Multiply, Minus, Equals
    }

    public TMP_Text result;

    public double SecondValue = 0.0;
    public bool SecondValueBool = true;
    public bool k = false;
    public double ThirdValue = 1;
    public  Stack<EnumOperation> stackOperation = new Stack<EnumOperation>();

    public double shablon(EnumOperation save, double value1, double value2)
    {
        switch (save)
        {
            case EnumOperation.Plus:
                {
                    return value1 + value2;
                }
            case EnumOperation.Minus:
                {
                    return value1 - value2;
                }
            case EnumOperation.Div:
                {
                    if (value2 == 0)
                        return double.NaN;
                    else
                        return value1 / value2;
                }
            case EnumOperation.Multiply:
                {
                    return value1 * value2;
                }
            default:
                {
                    return 0.0;
                }
        }
    }
}
