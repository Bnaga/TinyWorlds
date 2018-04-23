using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    private LineRenderer line;
    private Vector3 mousePos;
    private Vector3 startPos;
    private Vector4 endPos;

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
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (point1.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point1.transform.position);
                startPos = point1.transform.position;
            }

            if (point2.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point2.transform.position);
                startPos = point2.transform.position;
            }

            if (point3.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point3.transform.position);
                startPos = point3.transform.position;
            }

            if (point4.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point4.transform.position);
                startPos = point4.transform.position;
            }

            if (point5.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point5.transform.position);
                startPos = point5.transform.position;
            }
            if (point6.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point6.transform.position);
                startPos = point6.transform.position;
            }
            if (point7.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point7.transform.position);
                startPos = point7.transform.position;
            }
            if (point8.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point8.transform.position);
                startPos = point8.transform.position;
            }
            if (point9.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point9.transform.position);
                startPos = point9.transform.position;
            }
            if (point10.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point10.transform.position);
                startPos = point10.transform.position;
            }
            if (point11.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point11.transform.position);
                startPos = point11.transform.position;
            }
            if (point12.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point12.transform.position);
                startPos = point12.transform.position;
            }
            if (point13.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point13.transform.position);
                startPos = point13.transform.position;
            }
            if (point14.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point14.transform.position);
                startPos = point14.transform.position;
            }
            if (point15.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point15.transform.position);
                startPos = point15.transform.position;
            }
            if (point16.GetComponent<PointSelect>().hover)
            {
                CreateLine();
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(0, point16.transform.position);
                startPos = point16.transform.position;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {

            if (point1.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point1.transform.position);
                endPos = point1.transform.position;
            }

            if (point2.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point2.transform.position);
                endPos = point2.transform.position;
            }

            if (point3.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point3.transform.position);
                endPos = point3.transform.position;
            }

            if (point4.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point4.transform.position);
                endPos = point4.transform.position;
            }

            if (point5.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point5.transform.position);
                endPos = point5.transform.position;
            }
            if (point6.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point6.transform.position);
                endPos = point6.transform.position;
            }
            if (point7.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point7.transform.position);
                endPos = point7.transform.position;
            }
            if (point8.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point8.transform.position);
                endPos = point8.transform.position;
            }
            if (point9.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point9.transform.position);
                endPos = point9.transform.position;
            }
            if (point10.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point10.transform.position);
                endPos = point10.transform.position;
            }
            if (point11.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point11.transform.position);
                endPos = point11.transform.position;
            }
            if (point12.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point12.transform.position);
                endPos = point12.transform.position;
            }
            if (point13.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point13.transform.position);
                endPos = point13.transform.position;
            }
            if (point14.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point14.transform.position);
                endPos = point14.transform.position;
            }
            if (point15.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point15.transform.position);
                endPos = point15.transform.position;
            }
            if (point16.GetComponent<PointSelect>().hover)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                line.SetPosition(1, point16.transform.position);
                endPos = point16.transform.position;
            }
        }

    }

    void CreateLine()
    {
        line = new GameObject("Line").AddComponent<LineRenderer>();
        line.material = new Material(Shader.Find("Diffuse"));
        line.positionCount = 2;
        line.startWidth = .1f;
        line.endWidth = .1f;
        line.sortingOrder = 2;
        line.useWorldSpace = true;
    }
}
