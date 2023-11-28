using UnityEngine;
using TMPro;

public class PointSetting : MonoBehaviour
{

    public void OnClick()
    {
        if (int.TryParse(Variables.SharedInstance.result.text, out _))
        {
            Variables.SharedInstance.result.text += ".";
        }
        else
        {
            if (Variables.SharedInstance.result.text == "") Variables.SharedInstance.result.text = "0.";
            else
            {
                char c = Variables.SharedInstance.result.text[Variables.SharedInstance.result.text.Length - 1];
                if (c == '.')
                    Variables.SharedInstance.result.text = Variables.SharedInstance.result.text.Remove(Variables.SharedInstance.result.text.Length - 1);
            }
        }
    }

    public void OnGUI()
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown)
        {
            if (e.keyCode == KeyCode.Period)
            {
                this.OnClick();
                return;

            }
        }
    }


}
