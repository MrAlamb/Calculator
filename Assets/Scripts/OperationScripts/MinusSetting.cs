using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MinusSetting : MonoBehaviour
{

    public void OnClick()
    {
        if (double.TryParse(Variables.SharedInstance.result.text, out _))
            Functions.Do(Variables.EnumOperation.Minus, double.Parse(Variables.SharedInstance.result.text));
        else Functions.Do(Variables.EnumOperation.Minus, 0.0);
        Variables.SharedInstance.result.text = "";
    }
    public void Update()
    {
        if (Input.inputString == "-")
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }
    }
}
