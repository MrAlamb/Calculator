using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EqualsSettings : FunctionsAndVariables
{
    public TMP_Text result;

    public void OnClick()
    {
        FourthValue = double.Parse(result.text);

        operation = EnumOperation.Equals;
        Do();
        result.text = SecondValue.ToString();
    }

    public void Update()
    {
        if (Input.inputString == "=" || Input.GetKey(KeyCode.Return))
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }
    }
}
 