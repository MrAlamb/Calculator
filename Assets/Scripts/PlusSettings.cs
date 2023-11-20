using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlusSettings : FunctionsAndVariables
{
    public TMP_Text result;

    public void OnClick()
    {
        if (double.TryParse(result.text, out _))
            FourthValue = double.Parse(result.text);
        else FourthValue = 0.0;


        operation = EnumOperation.Plus;
        Do();
        result.text = "";
    }
    public void Update()
    {
        if (Input.inputString == "+")
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }
    }
}
