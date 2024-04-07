using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIdemo : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField userName;

    public void ButtonDemo()
    {
        output.text = " Hello there, " + userName.text;
    }

}
