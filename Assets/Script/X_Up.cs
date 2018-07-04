using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_Up : MonoBehaviour {

    public bool x_up_exist;
	// Use this for initialization
	void Start () {
        x_up_exist = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        x_up_exist = true;
    }

    private void OnTriggerExit(Collider other)
    {
        x_up_exist = false;
    }
}
