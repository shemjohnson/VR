using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ToggleTracking : MonoBehaviour
{
    public bool isRotTracking;
    public bool isMovTracking;
    // Start is called before the first frame update
    void Start()
    {
        isRotTracking = true;
	isMovTracking = true;
    }

    // Update is called once per frame
    void Update()
    {
	if(Input.GetKeyDown("r")){
	     isRotTracking = !isRotTracking;
        }
	if(Input.GetKeyDown("p")){
	     isMovTracking = !isMovTracking;
        }
	if(!isRotTracking)
	{
	    this.transform.position += -InputTracking.GetLocalPosition(XRNode.CenterEye);
	    
	} 
	if(!isMovTracking)
	{
	    this.transform.rotation = Quaternion.Inverse(InputTracking.GetLocalRotation(XRNode.CenterEye));
	}
    }
}
