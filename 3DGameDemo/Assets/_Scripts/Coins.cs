﻿using UnityEngine;
using System.Collections;

public class Coins : MonoBehaviour {
    //Public Instance Variables
    public GameController gameController;

    //Private Instance Variables
    private AudioSource _CoinSound;

    // Use this for initialization
    void Start () {
        this._CoinSound = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this._CoinSound.Play();
            gameController.ScoreValue += 100;
            Destroy(gameObject);
        }
    }
}
