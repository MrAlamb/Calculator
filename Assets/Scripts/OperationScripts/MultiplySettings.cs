using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MultiplySettings : MonoBehaviour
{
        public void OnClick()
        {
            if (double.TryParse(Variables.SharedInstance.result.text, out _))
                Functions.Do(Variables.EnumOperation.Multiply, double.Parse(Variables.SharedInstance.result.text));
            else Functions.Do(Variables.EnumOperation.Multiply, 1.0);
            Variables.SharedInstance.result.text = "";
        }

    public void Update()
    {
        if (Input.inputString == "*")
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }
    }
}
