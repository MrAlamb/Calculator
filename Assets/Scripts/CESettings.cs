using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CESettings : MonoBehaviour
{
    public TMP_Text result;
    // public string s = result;
    public void OnClick()
    {
        string s = result.text;
        result.text = "";
        for (int i = 0; i < s.Length - 1; i++)
            result.text += s[i];
       // TMP_Text save = ;
    }
}
