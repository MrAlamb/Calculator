using UnityEngine;

public class PlusMinusSettings : MonoBehaviour
{
    public void OnClick()
    {
        string v = (0 - double.Parse(Variables.SharedInstance.result.text)).ToString();
        Variables.SharedInstance.result.text = v;
    }
}
