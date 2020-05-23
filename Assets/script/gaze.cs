using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaze: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void gazeAtObj()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public void outFromObj()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
