using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour
{
    Vector3 startPlace;

    // Start is called before the first frame update
    void Start()
    {
        startPlace = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("tab")){
	     this.transform.position = startPlace;
        }
    }
}
