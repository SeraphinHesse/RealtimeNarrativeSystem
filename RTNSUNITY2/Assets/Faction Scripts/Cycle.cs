using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cycle : MonoBehaviour
{
    public TextMeshProUGUI output;
    
    int CycleCounter = 0;

    // Start is called before the first frame update
    void Start(){

    }

    public void NextCycle(){
        ++CycleCounter;
        Debug.Log("Cycle updated");
        output.text = "Cycle Counter: " + CycleCounter;
    }
    
}
