using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_Down : MonoBehaviour {

    public bool z_down_exist;
    // Use this for initialization
    void Start()
    {
        z_down_exist = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        z_down_exist = true;
    }

    private void OnTriggerExit(Collider other)
    {
        z_down_exist = false;
    }
}