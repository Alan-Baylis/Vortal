using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int coinAmount;
    public bool completeCoins;
    public AudioSource completeCoinsAudio;

	// Use this for initialization
	void Start () {
        coinAmount = 0;
        completeCoins = false;
	}
	
	// Update is called once per frame
	void Update () {

        // Check if player fell off.
        if(gameObject.transform.position.y <= -100)
        {
            gameObject.transform.position = new Vector3(0,2,-5);
        }

        // Player collected x_amount of coins.. yay
        if(coinAmount == 10 && completeCoins == false)
        {
            completeCoins = true;
            completeCoinsAudio.Play();
        }
            
	}
}
