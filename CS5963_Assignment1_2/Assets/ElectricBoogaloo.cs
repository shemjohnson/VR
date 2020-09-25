using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricBoogaloo : MonoBehaviour
{    

    public Light Light1;
    public Light Light2;
    public Light Light3;
    public Light Light4;
    public GameObject Collider2;
    public GameObject Collider3;
    public GameObject Collider4;
    public bool isInTrigger1;
    
    public int whichLight = 0;
    public double timeElapsed = 0.0;

    // Start is called before the first frame update
    void Start()
    {
        SwitchLight();
	
    }

    void SwitchLight()
    {
	timeElapsed = 0;
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
        timeElapsed += 0.0001;//Time.DeltaTime();
	if(timeElapsed >= 3)
	{   
	    SwitchLight();
	}
	if(isInTrigger1 && whichLight == 0)
	{
	   SwitchLight();
	} 
        if(Collider2.GetComponent<Collider2>().isInTrigger && whichLight == 1)
        {
          SwitchLight();
        }
        if(Collider3.GetComponent<Collider3>().isInTrigger && whichLight ==  2)
        {
          SwitchLight();
        }
        if(Collider4.GetComponent<Collider4>().isInTrigger && whichLight == 3)
        {
          SwitchLight();
        }
    }

    void OnTriggerExit(Collider other)
    {
   	isInTrigger1 = false;
    }
    void OnTriggerEnter(Collider other)
    {
   	isInTrigger1 = true;
    }
}
