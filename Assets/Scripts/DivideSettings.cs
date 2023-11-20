using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DivideSettings : FunctionsAndVariables
{
    public TMP_Text result;

    public void OnClick()
    {
        if (double.TryParse(result.text, out _))
            FourthValue = double.Parse(result.text);
        else FourthValue = 1.0;


        operation = EnumOperation.Div;
        Do();
        result.text = "";
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }
    }
}
