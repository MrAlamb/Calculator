using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MinusSetting : FunctionsAndVariables
{
    public TMP_Text result;
     
    public void OnClick()
    {
        if (double.TryParse(result.text, out _))
            FourthValue = double.Parse(result.text);
        else FourthValue = 0.0;


        operation = EnumOperation.Minus;
        Do();
        result.text = "";
    }
   
    public void Update()
    {
        if (Input.inputString == "-")
        {
            NewMethod();
        }
    }

    private void NewMethod()
    {
        gameObject.GetComponent<Button>().onClick.Invoke();
    }
}