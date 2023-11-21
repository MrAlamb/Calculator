using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EqualsSettings : MonoBehaviour
{
    public void OnClick()
    {
        if (double.TryParse(Variables.SharedInstance.result.text, out _))
            Functions.Do(Variables.EnumOperation.Equals, double.Parse(Variables.SharedInstance.result.text));
        else Functions.Do(Variables.EnumOperation.Equals, 0.0);
        Variables.SharedInstance.result.text = Variables.SharedInstance.SecondValue.ToString();
    }

    public void Update()
    {
        if (Input.inputString == "=" || Input.GetKey(KeyCode.Return))
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }
    }
}
 