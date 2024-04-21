using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class Cycle : MonoBehaviour
{
    public TextMeshProUGUI output;
    
    int CycleCounter = 0;

    public delegate void CycleUpdate();
    public static event CycleUpdate OnCycleUpdate;

    // Start is called before the first frame update
    void Start(){


    }

    public void NextCycle(){
        ++CycleCounter;
        OnCycleUpdate.Invoke();
        Debug.Log("Cycle updated");
        output.text = "Cycle Counter: " + CycleCounter;
        
    }
    
}
