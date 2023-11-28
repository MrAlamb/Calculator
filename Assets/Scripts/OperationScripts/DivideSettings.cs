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
        Variables.SharedInstance.result.text = "0";
    }
    public void OnGUI()
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown)
        {
            char c = e.character;
            if (c.ToString() == "/")
            {
                // Вызываем метод OnClick
                OnClick();
            }
        }
    }
}
