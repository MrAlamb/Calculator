using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FunctionsAndVariables : MonoBehaviour
{

    protected enum EnumOperation
    {
        Div, Plus, Multiply, Minus, Equals
    }
    protected static double SecondValue = 0.0;
    protected static bool SecondValueBool = true;
    protected static bool k = false;
    protected static double ThirdValue = 1;
    protected static double FourthValue = 0.0;
    protected static Stack<EnumOperation> stackOperation = new Stack<EnumOperation>();

    protected static EnumOperation operation;

    public TMP_Text result;
    protected static double  shablon(EnumOperation save, double value1, double value2)
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
                {if (value2 == 0)
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
        //return 0.1;
    }
    protected static void Do()
    {
        if (SecondValueBool)
        {
            if (operation == EnumOperation.Div || operation == EnumOperation.Multiply)
            { k = true; ThirdValue = FourthValue; }
            else
                SecondValue = FourthValue;

            SecondValueBool = false;
            stackOperation.Push(operation);
            Debug.Log("1");
//            Debug.Log(SecondValue + " " + ThirdValue + " " + FourthValue + " " + stackOperation.Count);
        }
        else
        {
            //if (!k)
            //{ ThirdValue = FourthValue; }
            switch (operation)
            {
                
                case EnumOperation.Plus or EnumOperation.Minus:
                    {
                        if (k)
                        {
                            FourthValue = shablon(stackOperation.Peek(), ThirdValue, FourthValue);
                            stackOperation.Pop();
                            SecondValue = shablon(stackOperation.Peek(), SecondValue, FourthValue);
                            stackOperation.Pop();
                            k = false;
                        }
                        else
                        {
                            SecondValue = shablon(stackOperation.Peek(), SecondValue, FourthValue);
                            stackOperation.Pop();
                        }
                        
                        stackOperation.Push(operation);
                        break;
                    }
                case EnumOperation.Div or EnumOperation.Multiply:
                    {
                        if (k)
                        {
                            ThirdValue = shablon(stackOperation.Peek(), ThirdValue, FourthValue);
                            stackOperation.Pop();
                        }
                        else
                        {
                            k = true;
                            ThirdValue = FourthValue;
                        }
                        stackOperation.Push(operation);
                        break;
                    }
                case EnumOperation.Equals:
                    {
                        while (stackOperation.TryPeek(out _))
                        {
                            if (stackOperation.Peek() == EnumOperation.Div || stackOperation.Peek() == EnumOperation.Multiply)
                            {
                                if (stackOperation.Count != 1)
                                FourthValue = shablon(stackOperation.Peek(), ThirdValue, FourthValue);
                                else SecondValue = shablon(stackOperation.Peek(), ThirdValue, FourthValue);
                            }
                            else
                                SecondValue = shablon(stackOperation.Peek(), SecondValue, FourthValue);
                            stackOperation.Pop();
                        }
                        ThirdValue = 0;
                        FourthValue = 0;
                        k = false;
                        SecondValueBool = true;
                        break;
                    }
                
            }
        }

        //else

            //switch (operation)
            //{
            //    case EnumOperation.Plus or EnumOperation.Minus:
            //        {
            //            if (stackOperation.TryPeek(out _))
            //                switch (stackOperation.Peek())
            //                {
            //                    case EnumOperation.Plus:
            //                        {
            //                            SecondValue += ThirdValue;
            //                            ThirdValue = 0;
            //                            stackOperation.Pop();
            //                            break;
            //                        }

            //                    case EnumOperation.Minus:
            //                        {
            //                            SecondValue -= ThirdValue;
            //                            ThirdValue = 0;
            //                            stackOperation.Pop();
            //                            break;
            //                        }

            //                    case EnumOperation.Multiply:
            //                        {

            //                            ThirdValue *= FourthValue;
            //                            stackOperation.Pop();
            //                            if (stackOperation.Peek() == EnumOperation.Plus)
            //                                SecondValue += ThirdValue;
            //                            else
            //                                SecondValue -= ThirdValue;
            //                            stackOperation.Pop();
            //                            Debug.Log(stackOperation.Count);
            //                            break;
            //                        }
            //                    case EnumOperation.Div:

            //                        {
            //                            ThirdValue /= FourthValue;
            //                            stackOperation.Pop();
            //                            if (stackOperation.Peek() == EnumOperation.Plus)
            //                                SecondValue += ThirdValue;
            //                            else
            //                                SecondValue -= ThirdValue;
            //                            stackOperation.Pop();
            //                            Debug.Log(stackOperation.Count);
            //                            break;
            //                        }
            //                }
            //            Debug.Log(SecondValue + " " + ThirdValue + " " + FourthValue + " " + stackOperation.Count);
            //            ThirdValue = FourthValue;


            //            if (operation != EnumOperation.Equals)
            //                stackOperation.Push(operation);

                       
            //            break;
            //        }

            //    case EnumOperation.Div or EnumOperation.Multiply:
            //        {

            //            if (stackOperation.TryPeek(out _))
            //            {
            //                switch (stackOperation.Peek())
            //                {
            //                    case EnumOperation.Plus or EnumOperation.Minus:
            //                        {
            //                            SecondValue += ThirdValue;
            //                            ThirdValue = FourthValue;
            //                            stackOperation.Push(operation);
            //                            Debug.Log(SecondValue + " " + ThirdValue + " " + FourthValue + " " + stackOperation.Count);
            //                            break;
            //                        }
            //                    case EnumOperation.Multiply:
            //                        {
            //                                ThirdValue *= FourthValue;
            //                            stackOperation.Pop();
            //                            stackOperation.Push(operation);
            //                            Debug.Log(SecondValue + " " + ThirdValue + " " + FourthValue + " " + stackOperation.Count);
            //                            break;
            //                        }
            //                    case EnumOperation.Div:
            //                        {
            //                            ThirdValue /= FourthValue;
            //                            stackOperation.Pop();
            //                            stackOperation.Push(operation);
            //                            Debug.Log(SecondValue + " " + ThirdValue + " " + FourthValue + " " + stackOperation.Count);

            //                            break;
            //                        }
            //                }

            //            }
            //            else
            //            {
            //                Debug.Log("NENORM");
            //                ThirdValue = FourthValue;
            //                stackOperation.Push(operation);
            //            }
            //            break;
            //        }


            //    case EnumOperation.Equals:
            //        {
            //           // if (stackOperation.Peek() == EnumOperation.Minus || stackOperation.Peek() == EnumOperation.Plus)
            //             //   stackOperation.Pop();
            //            while (stackOperation.TryPeek(out _))
            //            {
            //                switch (stackOperation.Peek())
            //                {
            //                    case EnumOperation.Plus:
            //                        {
            //                            SecondValue += FourthValue;
            //                            ThirdValue = 0;
            //                            stackOperation.Pop();
            //                            Debug.Log("1+");
            //                            break;
            //                        }

            //                    case EnumOperation.Minus:
            //                        {
            //                            SecondValue -= FourthValue;
            //                            ThirdValue = 0;
            //                            stackOperation.Pop();
            //                            Debug.Log("1-");
            //                            break;
            //                        }

            //                    case EnumOperation.Multiply:
            //                        {
            //                            ThirdValue *= FourthValue;
            //                            if (stackOperation.Count == 1)
            //                            SecondValue = ThirdValue;
            //                            stackOperation.Pop();
            //                            Debug.Log("1*");
            //                            break;
            //                        }
            //                    case EnumOperation.Div:

            //                        {
            //                            ThirdValue /= FourthValue;
            //                            if (stackOperation.Count == 1)
            //                                SecondValue = ThirdValue;
            //                            stackOperation.Pop();
            //                            Debug.Log("1/");
            //                            break;
            //                        }
            //                }
            //                //ThirdValue = FourthValue;
            //            }
            //            SecondValueBool = true;
            //            ThirdValue = 0;
            //            FourthValue = 0;
            //            break;


                    //}
            //}
    }


}
    
