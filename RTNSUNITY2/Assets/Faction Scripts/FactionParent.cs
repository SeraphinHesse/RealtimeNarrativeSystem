using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FactionParent : MonoBehaviour
{
    public TextMeshProUGUI output;
    

    int Wealth = 5;
    int Manpower = 0;
    int ManpowerInf = 0;
    int Equipment = 0;
    int EquipmentInf = 0;
    int Influence = 0;
    int Intelligence = 0;
    int Cohesion = 0;

    // Start is called before the first frame update
    void Start(){
        Cycle.OnCycleUpdate += UpdateStats;
    }

    void FactionCycleUpdate()
    {
        
    }


    
    void UpdateStats()
    {
        Debug.Log("it Worked!!");
      
    }
}
