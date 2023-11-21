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
    public void OnGUI()
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown)
        {
            char c = e.character;
            if (c.ToString() == "+")
            {
                OnClick();
            }
        }
    }
}
