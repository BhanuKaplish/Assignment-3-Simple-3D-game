using UnityEngine;
using System.Collections;

public class WinningScript : MonoBehaviour {
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
            Debug.Log("Touching Cup");
            Destroy(gameObject);

            gameController.LivesValue = 0;
        }
    }
}
