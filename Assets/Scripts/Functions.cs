using System;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public static double shablon(Variables.EnumOperation save, double value1, double value2)
    {
        switch (save)
        {
            case Variables.EnumOperation.Plus:
                {
                    return value1 + value2;
                }
            case Variables.EnumOperation.Minus:
                {
                    return value1 - value2;
                }
            case Variables.EnumOperation.Div:
                {
                    if (value2 == 0)
                        return double.NaN;
                    else
                        return value1 / value2;
                }
            case Variables.EnumOperation.Multiply:
                {
                    return value1 * value2;
                }
            default:
                {
                    return 0.0;
                }
        }
    }

    public static void Do(Variables.EnumOperation operation, double FourthValue)
    {
        if (Variables.SharedInstance.SecondValueBool)
        {
            if (operation == Variables.EnumOperation.Div || operation == Variables.EnumOperation.Multiply)
            {
                Variables.SharedInstance.k = true;
                Variables.SharedInstance.ThirdValue = FourthValue;
            }
            else
                Variables.SharedInstance.SecondValue = FourthValue;

            Variables.SharedInstance.SecondValueBool = false;
            Variables.SharedInstance.stackOperation.Push(operation);
        }
        else
        {

            switch (operation)
            {

                case Variables.EnumOperation.Plus or Variables.EnumOperation.Minus:
                    {
                        if (Variables.SharedInstance.k)
                        {
                            FourthValue = shablon(Variables.SharedInstance.stackOperation.Peek(), Variables.SharedInstance.ThirdValue, FourthValue);
                            Variables.SharedInstance.stackOperation.Pop();
                            if (Variables.SharedInstance.stackOperation.Count != 0)
                            {
                                Variables.SharedInstance.SecondValue = shablon(Variables.SharedInstance.stackOperation.Peek(), Variables.SharedInstance.SecondValue, FourthValue);
                                Variables.SharedInstance.stackOperation.Pop();
                            }
                            else Variables.SharedInstance.SecondValue = FourthValue;
                            Variables.SharedInstance.k = false;
                        }
                        else
                        {
                            Variables.SharedInstance.SecondValue = shablon(Variables.SharedInstance.stackOperation.Peek(), Variables.SharedInstance.SecondValue, FourthValue);
                            Variables.SharedInstance.stackOperation.Pop();
                        }

                        Variables.SharedInstance.stackOperation.Push(operation);
                        break;
                    }
                case Variables.EnumOperation.Div or Variables.EnumOperation.Multiply:
                    {
                        if (Variables.SharedInstance.k)
                        {
                            Variables.SharedInstance.ThirdValue = shablon(Variables.SharedInstance.stackOperation.Peek(), Variables.SharedInstance.ThirdValue, FourthValue);
                            Variables.SharedInstance.stackOperation.Pop();
                        }
                        else
                        {
                            Variables.SharedInstance.k = true;
                            Variables.SharedInstance.ThirdValue = FourthValue;
                        }
                        Variables.SharedInstance.stackOperation.Push(operation);
                        break;
                    }
                case Variables.EnumOperation.Equals:
                    {
                        while (Variables.SharedInstance.stackOperation.TryPeek(out _))
                        {
                            if (Variables.SharedInstance.stackOperation.Peek() ==  Variables.EnumOperation.Div || Variables.SharedInstance.stackOperation.Peek() == Variables.EnumOperation.Multiply)
                            {
                                if (Variables.SharedInstance.stackOperation.Count != 1)
                                    FourthValue = shablon(Variables.SharedInstance.stackOperation.Peek(), Variables.SharedInstance.ThirdValue, FourthValue);
                                else Variables.SharedInstance.SecondValue = shablon(Variables.SharedInstance.stackOperation.Peek(), Variables.SharedInstance.ThirdValue, FourthValue);
                            }
                            else
                                Variables.SharedInstance.SecondValue = shablon(Variables.SharedInstance.stackOperation.Peek(), Variables.SharedInstance.SecondValue, FourthValue);
                           // Variables.SharedInstance.SecondValue = shablon(Variables.SharedInstance.stackOperation.Peek(), Variables.SharedInstance.SecondValue, FourthValue);
                            Variables.SharedInstance.stackOperation.Pop();
                        }
                        Variables.SharedInstance.ThirdValue = 0;
                        Variables.SharedInstance.k = false;
                        Variables.SharedInstance.SecondValueBool = true;
                        break;
                    }

            }
        }
    }


}
    
