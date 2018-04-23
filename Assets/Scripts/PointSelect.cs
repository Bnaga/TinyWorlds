using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSelect : MonoBehaviour {

    // Use this for initialization
    public bool hover = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        hover = true;
    }

    private void OnMouseExit()
    {
        hover = false;
    }
}
