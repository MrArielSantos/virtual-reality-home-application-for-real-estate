using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changescene : MonoBehaviour
{
    public GameObject on;
    public GameObject off;
   

    public void OnandOff()
    {
        
        
            on.SetActive(true); // ! not operator
            off.SetActive(false); 
   
    }

    
}
