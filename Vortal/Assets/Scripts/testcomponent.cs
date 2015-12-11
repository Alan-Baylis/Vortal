using UnityEngine;
using System.Collections;

public class testcomponent : MonoBehaviour {


    Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rigidBody.AddForce(new Vector3(0,1,0)*10,ForceMode.Force);
	}
}
