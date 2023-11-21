using UnityEngine;
using UnityEngine.UI;

public class PlusSettings : MonoBehaviour
{

    public void OnClick()
    {
        if (double.TryParse(Variables.SharedInstance.result.text, out _))
            Functions.Do(Variables.EnumOperation.Plus, double.Parse(Variables.SharedInstance.result.text));
        else Functions.Do(Variables.EnumOperation.Plus, 0.0);
        Variables.SharedInstance.result.text = "";
    }
    public void Update()
    {
        if (Input.inputString == "+")
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }
    }
}
