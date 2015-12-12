﻿using UnityEngine;
using System.Collections;

public class Linecast : MonoBehaviour {

    public LineRenderer line;
    public RaycastHit hit;
    public Vector3 linestart;
    public bool grabby;
    public GameObject carriedObject;
    public float grabbedTime;
    private GameObject objectHit;


	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
        linestart = transform.position - new Vector3(0, 0.5f, 0);
        line.SetPosition(0, linestart);
        if (Physics.Raycast(linestart, transform.forward, out hit, 2))
        {
            line.SetPosition(1, hit.point);
            line.SetWidth(0,0);
            objectHit = hit.transform.gameObject;
            if(Input.GetKeyDown(KeyCode.E) && (hit.transform.tag == "Grabbable") && !grabby)
            {
                carriedObject = hit.transform.gameObject;
                carriedObject.GetComponent<Rigidbody>().useGravity = false;
                carriedObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                carriedObject.GetComponent<Rigidbody>().freezeRotation = true;
                carriedObject.GetComponent<Rigidbody>().isKinematic = true;
                grabby = true;
                grabbedTime = Time.time;
                carriedObject.transform.SetParent(transform);
                carriedObject.transform.localPosition = new Vector3(0,0,2);
            }
        }
        else
        {
            line.SetPosition(1, linestart);
        }
        if(grabby && Input.GetKeyDown(KeyCode.E) && (Time.time - grabbedTime > 0.1))
        {
            carriedObject.GetComponent<Rigidbody>().useGravity = true;
            carriedObject.GetComponent<Rigidbody>().freezeRotation = false;
            carriedObject.GetComponent<Rigidbody>().isKinematic = false;
            grabby = false;
            carriedObject.transform.SetParent(null);
        }
    }
}
