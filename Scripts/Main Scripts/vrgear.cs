using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrgear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.XR.XRSettings.enabled = true;
       Camera.main.ResetAspect();
      // Camera.main.GetComponent<Transform>().localRotation = UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.LeftEye);
    }

   
}
