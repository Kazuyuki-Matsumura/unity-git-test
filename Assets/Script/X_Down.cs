using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_Down : MonoBehaviour {

    public bool x_down_exist;
    // Use this for initialization
    void Start()
    {
        x_down_exist = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        x_down_exist = true;
    }

    private void OnTriggerExit(Collider other)
    {
        x_down_exist = false;
    }
}