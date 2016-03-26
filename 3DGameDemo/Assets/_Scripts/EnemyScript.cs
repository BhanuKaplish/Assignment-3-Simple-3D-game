using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
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
            //this._BonusSound.Play();
            gameController.LivesValue -= 1;
        }
        if (other.gameObject.CompareTag("WinningCup"))
        {
            gameController.LivesValue = 0;
            Destroy(other.gameObject);
        }
    }
}
