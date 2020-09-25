using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElectricBoogaloo : MonoBehaviour
{    

    public GameObject ui;
    public Text message;
    public Light Light1;
    public Light Light2;
    public Light Light3;
    public Light Light4;
    public GameObject Collider2;
    public GameObject Collider3;
    public GameObject Collider4;
    public bool isInTrigger1;
    public int score = 0;
    
    public int whichLight = 0;
    public double timeElapsed = 0.0;

    // Start is called before the first frame update
    void Start()
    {
        SwitchLight();

        ui = GameObject.Find("UIText");
        message = ui.GetComponent<Text>();
        message.text = "Score: " + score + "\n Stand directly next to the red light and press button one to get a point.\nPress button two to exit the game.";
	
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
	message.text = "Score: " + score + "\n Stand directly next to the red light and press button one to get a point.\nPress button two to exit the game.";
        timeElapsed += Time.deltaTime;
	if(timeElapsed >= 3)
	{   
	    SwitchLight();
	}
	if(isInTrigger1 && whichLight == 0 && OVRInput.Get(OVRInput.Button.One))
	{
           score++;
	   SwitchLight();
	} 
        if(Collider2.GetComponent<Collider2>().isInTrigger && whichLight == 1  && OVRInput.Get(OVRInput.Button.One))
        {
	  score++;
          SwitchLight();
        }
        if(Collider3.GetComponent<Collider3>().isInTrigger && whichLight ==  2  && OVRInput.Get(OVRInput.Button.One))
        {
           score++;
          SwitchLight();
        }
        if(Collider4.GetComponent<Collider4>().isInTrigger && whichLight == 3  && OVRInput.Get(OVRInput.Button.One))
        {
           score++;
          SwitchLight();
        }
	if(OVRInput.Get(OVRInput.Button.Two))
	{
	     #if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
	     #else
		Application.Quit();
	     #endif
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
