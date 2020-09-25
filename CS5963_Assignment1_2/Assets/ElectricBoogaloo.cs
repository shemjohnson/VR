using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricBoogaloo : MonoBehaviour
{    

    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    
    public int whichLight = 0;
    public float timeElapsed = 0.0

    // Start is called before the first frame update
    void Start()
    {
        SwitchLight();
	
    }

    void SwitchLight()
    {
	Light1.enabled = false;
	Light2.enabled = false;
	Light3.enabled = false;
	Light4.enabled = false;
	whichLight = Random.Range(0, 3);
	if(whichLight == 0)
	    Light1.enabled = true;
	if(whichLight == 1)
	    Light2.enabled = true;
	if(whichLight == 2)
	    Light3.enabled = true;
	if(whichLight == 3)
	    Light4.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.DeltaTime();
	If(timeElapsed >= 3)
	{
	    timeElapsed = 0;
	    SwitchLight;
	}
    }
}
