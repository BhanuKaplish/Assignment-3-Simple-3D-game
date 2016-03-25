///<File Name: GameController.cs>
///<Author Name: Bhanu Kaplish>
///<Description: This script is attached to the game controller object which controls features like labels>

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    //Private Instance variables
    private int _scoreValue;
    private int _livesValue;
    //[SerializeField]
    //private AudioSource _gameoverSound;

    //private Variables
    private Vector3 _playerSpawnPoint;

    // PUBLIC ACCESS METHODS
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else {
                this.LivesLabel.text = "lives: " + this._livesValue;
            }
        }
    }



    //Public Instance Variables
    //public int asteroidNumber = 4;
    //public PlaneController plane;
    //public CoinController coin;
    //public AsteroidController asteroid;
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text GameOverLabel;
    public Text HighscoreLabel;
    public Button RestartButton;
    public GameObject player;

    // Use this for initialization
    void Start() {
        initialize();

        Instantiate(this.player, this._playerSpawnPoint, Quaternion.identity);
    }

// Update is called once per frame
	void Update () {
	
	}

    //Private method
    private void initialize()
    {
        this._playerSpawnPoint = new Vector3(8.0f, 2.0f, 20.0f);
        this._livesValue = 5;
        this._scoreValue = 0;
        this.GameOverLabel.enabled = false;
        this.HighscoreLabel.enabled = false;
        this.RestartButton.gameObject.SetActive(false);
                
    }
    private void _endGame()
    {
        this.HighscoreLabel.text = "Highscore : " + this._scoreValue;     
        this.GameOverLabel.enabled = true;
        this.HighscoreLabel.enabled = true;
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        //this.plane.gameObject.SetActive(false);
        //this.coin.gameObject.SetActive(false);
        this.RestartButton.gameObject.SetActive(true);
        //this._gameoverSound.Play();
    }
   // Public methods
    public void RestartButtonClick()
    {
        //Application.LoadLevel("main");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
