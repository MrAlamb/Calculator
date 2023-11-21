using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DivideSettings : MonoBehaviour
{
    public void OnClick()
    {
        if (double.TryParse(Variables.SharedInstance.result.text, out _))
            Functions.Do(Variables.EnumOperation.Div, double.Parse(Variables.SharedInstance.result.text));
        else Functions.Do(Variables.EnumOperation.Div, 1.0);
        Variables.SharedInstance.result.text = "";
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }
    }
}
