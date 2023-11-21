using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EqualsSettings : MonoBehaviour
{
    public void OnClick()
    {
        if (double.TryParse(Variables.SharedInstance.result.text, out _))
            if (Variables.SharedInstance.stackOperation.Count == 0)
            {
                double lasts = Variables.SharedInstance.LastValue;
                Functions.Do(Variables.SharedInstance.LastOperation, double.Parse(Variables.SharedInstance.result.text));
                Functions.Do(Variables.EnumOperation.Equals, lasts);
                Variables.SharedInstance.LastValue = lasts;
            }
            else
                Functions.Do(Variables.EnumOperation.Equals, double.Parse(Variables.SharedInstance.result.text));
        else
            if (Variables.SharedInstance.LastOperation == Variables.EnumOperation.Div || Variables.SharedInstance.LastOperation == Variables.EnumOperation.Multiply)
            Functions.Do(Variables.EnumOperation.Equals, 1.0);
            else
            Functions.Do(Variables.EnumOperation.Equals, 0.0); 
        Variables.SharedInstance.result.text = Variables.SharedInstance.SecondValue.ToString();
    }

    public void OnGUI()
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown)
        {
            char c = e.character;
            if (c.ToString() == "=" || e.keyCode == KeyCode.Return)
            {
                OnClick();
            }
        }
    }
}
