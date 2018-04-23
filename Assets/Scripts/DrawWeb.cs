using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWeb : MonoBehaviour {

    private LineRenderer[] line;
    private Vector3 mousePos;
    private Vector3[] startPos;
    private Vector4[] endPos;
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;
    public GameObject point5;
    public GameObject point6;
    public GameObject point7;
    public GameObject point8;
    public GameObject point9;
    public GameObject point10;
    public GameObject point11;
    public GameObject point12;
    public GameObject point13;
    public GameObject point14;
    public GameObject point15;
    public GameObject point16;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if ( Input.GetMouseButtonDown(0))
        {
            if(line == null)
            {
                CreateLine(0);
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line[0].SetPosition(0, mousePos);
                startPos[0] = mousePos;
            }

            for (int i = 0; i < line.Length + 1; i++)
            {
                CreateLine(i);
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line[i].SetPosition(0, mousePos);
                startPos[i] = mousePos;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            for(int i=0; i < line.Length +1; i++)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line[i].SetPosition(1, mousePos);
                endPos[i] = mousePos;
            }
        }

	}

    void CreateLine(int i)
    {
        line[i] = new GameObject("Line").AddComponent<LineRenderer>();
        line[i].material = new Material(Shader.Find("Diffuse"));
        line[i].positionCount = 2;
        line[i].startWidth = 1;
        line[i].endWidth = 1;
        line[i].sortingOrder = 2;
        line[i].useWorldSpace = true;
    }
}
