using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSwitch : MonoBehaviour
{
    public bool hasSwitched;
	
    // Start is called before the first frame update
    void Start()
    {
       hasSwitched = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("2") && (!hasSwitched)){
	     this.transform.position += new Vector3(75, 0, 0);
	     hasSwitched = true;
        }
 	if(Input.GetKeyDown("1") && (hasSwitched)){
	     this.transform.position += new Vector3(-75, 0, 0);
	     hasSwitched = false;
        }
	if (Input.GetKeyDown(KeyCode.Escape))
	{
	     #if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
	     #else
		Application.Quit();
	     #endif
	}
    }
}
