using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FactionParent : MonoBehaviour
{
    public TextMeshProUGUI Wealthtxt;
    public TextMeshProUGUI WealthInftxt;

// Wealth = HardStats[0] | Manpower = Hardstats[1] | Equipment = HardStats[2]
    int[] HardStats = {5, 1, 2};
// WealthInf = Infrastucture[0] | Manpower = Infrastructure[1] | Infrastructure = HardStats[2]
    int[] Infrastucture = {2, 0, 0};
// Influence = SoftStats[0] | Intelligence = SoftStats[1] | Cohesion = Softstats[2]
    int[] Softstats = {2, 0, 0};
/*
    int Wealth = 5;
    int WealthInf = 2;
    int Manpower = 0;
    int ManpowerInf = 0;
    int Equipment = 0;
    int EquipmentInf = 0;
    int Influence = 0;
    int Intelligence = 0;
    int Cohesion = 0;
*/

    // Start is called before the first frame update
    void Start(){
        
        Cycle.OnCycleUpdate += UpdateStats;
        Wealthtxt.text = HardStats[0].ToString();
        WealthInftxt.text = Infrastucture[0].ToString();
        for (int i = 0; i < HardStats.Length ; i++){
        Debug.Log(HardStats[i]);
        }
    
        
    }

    void FactionCycleUpdate()
    {
        
    }


    
    void UpdateStats()
    {
        Debug.Log("it Worked!!");
        HardStats[0] = HardStats[0] + (Infrastucture[0] / 2);
        Wealthtxt.text = HardStats[0].ToString();
            ;

      
    }
}
