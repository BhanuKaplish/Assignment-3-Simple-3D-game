///<File Name: PlayerController.cs>
///<Author Name: Bhanu Kaplish>
///<Description: This script is attached to the player of the game which handles the labels using gameController's object>

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //Public Instance Variables
    public GameController gameController;

    //Private Instance Variables
    //private AudioSource _BonusSound;
    private AudioSource _CoinSound;

    // Use this for initialization
    void Start ()
    {
        //this._BonusSound = gameObject.GetComponent<AudioSource>();
        this._CoinSound = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.CompareTag("Enemy"))
        //{
        //    this._asteroidSound.Play();
        //}
        //if (other.gameObject.CompareTag("Heart"))
        //{
        //    this._BonusSound.Play();
        //}
        if (other.gameObject.CompareTag("Coins"))
        {
            Debug.Log("TheCoin!");
            this._CoinSound.Play();
        }
    }
    public void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Coins"))
        {
            this._CoinSound.Play();
        }
    }
}
