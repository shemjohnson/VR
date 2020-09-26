using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRMirror : MonoBehaviour
{
    public bool isMirror;
    // Start is called before the first frame update
    void Start()
    {
        isMirror = false;
    }

    // Update is called once per frame
    void Update()
    {
	if(Input.GetKeyDown("m")){
	     isMirror = !isMirror;
        }
        if(isMirror)
	{
	    this.transform.position += -InputTracking.GetLocalPosition(XRNode.CenterEye);
	this.transform.rotation = Quaternion.Inverse(InputTracking.GetLocalRotation(XRNode.CenterEye));
	    
	} 
	if(!isMirror)
	{
	    this.transform.rotation = InputTracking.GetLocalRotation(XRNode.CenterEye);
this.transform.position += InputTracking.GetLocalPosition(XRNode.CenterEye);
	}
    }
}
