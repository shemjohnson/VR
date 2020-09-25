using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2 : MonoBehaviour
{
    public bool isInTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
   	isInTrigger = true;
    }

    public void OnTriggerExit(Collider other)
    {
   	isInTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
