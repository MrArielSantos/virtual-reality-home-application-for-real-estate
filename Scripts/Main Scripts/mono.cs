using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class mono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //UnityEngine.XR.XRSettings.enabled = false;
       

        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.XR.XRSettings.enabled = false;
        Camera.main.ResetAspect();
        Camera.main.GetComponent<Transform>().localRotation = UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.CenterEye);
    }
}
