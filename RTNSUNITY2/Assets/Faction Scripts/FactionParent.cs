using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FactionParent : MonoBehaviour
{
    public TextMeshProUGUI output;
    int Cycle = 0;

    // Start is called before the first frame update
    void Start()
    {
    
    
    int Wealth = 5;
    int Manpower = 0;
    int ManpowerInf = 0;
    int Equipment = 0;
    int EquipmentInf = 0;
    int Influence = 0;
    int Intelligence = 0;
    int Cohesion = 0;
    
    Debug.Log(Wealth);
    }

    public void NextCycle(){
        
        ++Cycle;
        Debug.Log("Yay");
        output.text = "Cycle Counter: " + Cycle;
    }
    
}
