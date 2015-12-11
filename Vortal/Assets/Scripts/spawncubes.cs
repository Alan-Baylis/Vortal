using UnityEngine;
using System.Collections;

public class spawncubes : MonoBehaviour {

    
    public GameObject userRef;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {

        if(Input.GetMouseButtonDown(0))
        { 
            GameObject newObject = (GameObject)GameObject.Instantiate(Resources.Load("newCube"), userRef.transform.GetChild(0).position + 2 * userRef.transform.GetChild(0).forward, Quaternion.identity);
            newObject.name = "Cube";
         }
	}
}
