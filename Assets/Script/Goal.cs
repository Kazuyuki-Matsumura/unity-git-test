using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public GameObject goal_window;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            goal_window.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
