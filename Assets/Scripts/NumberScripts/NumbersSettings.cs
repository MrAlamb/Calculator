using UnityEngine;
using TMPro;

public class NumbersSettings : MonoBehaviour
{
    public TMP_Text Text;

    public void OnClick()
    {
        
        if (Variables.SharedInstance.result.text == "NaN" || Variables.SharedInstance.result.text == "" || Variables.SharedInstance.result.text == "0")
            Variables.SharedInstance.result.text = Text.text;
        else
            Variables.SharedInstance.result.text += Text.text;

    }

    public void OnGUI()
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown)
        {
            char c = e.character;
            if (c.ToString() == Text.text)
            {
                OnClick(); 
                e.Use();
            }
        }
    }

}
