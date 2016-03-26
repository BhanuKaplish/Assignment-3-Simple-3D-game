using UnityEngine;
using System.Collections;

public class HeartsController : MonoBehaviour {
    //Public Instance Variables
    public GameController gameController;

    //Private Instance Variables
    private AudioSource _BonusSound;

    // Use this for initialization
    void Start () {
        this._BonusSound = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this._BonusSound.Play();
            gameController.LivesValue += 1;
            Destroy(gameObject);
        }
    }
}

