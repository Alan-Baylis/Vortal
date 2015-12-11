using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

    public SpringJoint spring;
    public GameObject bottom;
    public AudioSource audio;
    public bool isTriggered = false;

	// Use this for initialization
	void Start () {
        spring = GetComponent<SpringJoint>();
	}
	
	// Update is called once per frame
	void Update () {
        if ((spring.transform.position.y - bottom.transform.position.y < 0.2))
        {
            if ( isTriggered == false) {
                isTriggered = true;
                Debug.Log("Swith has been triggered!!");
                audio.Play();
            }
        }
        else
        {
            isTriggered = false;
        }
	}
}
