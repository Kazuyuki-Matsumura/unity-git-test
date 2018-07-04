using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_Up : MonoBehaviour {

    public bool z_up_exist;
    // Use this for initialization
    void Start()
    {
        z_up_exist = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        z_up_exist = true;
    }

    private void OnTriggerExit(Collider other)
    {
        z_up_exist = false;
    }
}