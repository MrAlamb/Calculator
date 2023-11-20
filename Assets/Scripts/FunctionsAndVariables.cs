using System.Collections.Generic;
using UnityEngine;

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
    protected  double FourthValue = 0.0;
    protected static Stack<EnumOperation> stackOperation = new Stack<EnumOperation>();

    protected static EnumOperation operation;
    protected  double shablon(EnumOperation save, double value1, double value2)
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
    public  void Do()
    {
        if (SecondValueBool)
        {
            if (operation == EnumOperation.Div || operation == EnumOperation.Multiply)
            { k = true; ThirdValue = FourthValue; }
            else
                SecondValue = FourthValue;

            SecondValueBool = false;
            stackOperation.Push(operation);
        }
        else
        {

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
    }


}
    
