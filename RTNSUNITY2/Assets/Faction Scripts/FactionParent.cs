using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FactionParent : MonoBehaviour
{
    public TextMeshProUGUI output;

    // Start is called before the first frame update
    void Start()
    {
    
    int Cycle = 0;
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
        int Cycle = 0;
        Cycle += 1;
        Debug.Log("Yay");
        output.text = "Cycle Counter: " + Cycle;
    }
    
}
