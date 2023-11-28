using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CESettings : MonoBehaviour
{
    public void OnClick()
    {
        if (Variables.SharedInstance.result.text == "NaN")
        {
            Variables.SharedInstance.result.text = "0";
        }
        else
        {
            string s = Variables.SharedInstance.result.text;
            Variables.SharedInstance.result.text = "";
            if (s.Length - 1 == 0) Variables.SharedInstance.result.text = "0";
            for (int i = 0; i < s.Length - 1; i++)
                Variables.SharedInstance.result.text += s[i];
        }
    }
    public void OnGUI()
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown)
        {
          //  char c = e.character;
            if (e.keyCode == KeyCode.Backspace)
            {
                OnClick();
            }
        }
    }
}
