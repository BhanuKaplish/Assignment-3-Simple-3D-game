using UnityEngine;
using System.Collections;

public class Coins : MonoBehaviour {
    //Public Instance Variables
    public GameController gameController;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameController.ScoreValue += 100;
            Destroy(gameObject);
        }
    }
}
