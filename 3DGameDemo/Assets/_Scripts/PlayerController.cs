///<File Name: PlayerController.cs>
///<Author Name: Bhanu Kaplish>
///<Description: This script is attached to the player of the game which handles the labels using gameController's object>

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //Public Instance Variables
    public GameController gameController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.CompareTag("Enemy"))
        //{
        //    this._asteroidSound.Play();
        //    this.gameController.livesValue -= 1;
        //}
        if (other.gameObject.CompareTag("Heart"))
        {
            //this._asteroidSound.Play();
            this.gameController.LivesValue += 1;
        }
        if (other.gameObject.CompareTag("Coins"))
        {
            //this._coinSound.Play();
            this.gameController.ScoreValue += 100;
            Destroy(gameObject);
        }
    }
}
