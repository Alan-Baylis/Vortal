using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public AudioSource audio;
    public ParticleSystem particles;
    public bool isHit;
    public float hitTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(!isHit)
        {
            transform.Rotate(0, 360*Time.deltaTime, 0);
        }
        else
        {
            transform.Rotate(0, 920*Time.deltaTime,0);
        }
        if (Time.time - hitTime > 1 && isHit)
        {
            DestroyImmediate(gameObject);
        } 
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isHit && other.gameObject.name == "FPSController")
        {
            hitTime = Time.time;
            Debug.Log("Coin Collision!");
            audio.Play();
            particles.Emit(100);
            isHit = true;
        }
        
    }


}
