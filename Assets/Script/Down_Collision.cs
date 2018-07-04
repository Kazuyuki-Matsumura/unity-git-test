using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down_Collision : MonoBehaviour {

    public bool down_exist;
	// Use this for initialization
	void Start () {
        down_exist = false;
    }
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerEnter(Collider other)
    {
        down_exist = true;
    }

    private void OnTriggerExit(Collider other)
    {
        down_exist = false;
    }
}
