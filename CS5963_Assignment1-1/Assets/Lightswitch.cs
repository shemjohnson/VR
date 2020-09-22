using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    public Light light;
    public bool isRed;

    // Start is called before the first frame update
    void Start()
    {
        light = this.GetComponent<Light>();
	isRed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("tab")){
	    if(!isRed)
	    {
		isRed = true;
            	light.color = Color.red;
	    }
	    else
	    {
		isRed = false;
		light.color = Color.white;
	    }
        }
    }
}
