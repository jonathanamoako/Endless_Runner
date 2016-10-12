using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    public static int score = 0;
    public int highScore = 0;
    string highScoreKey = "HighScore";

    [SerializeField]
    private Text scoreText;
    
    

    // Use this for initialization
    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "Score:" + score.ToString();
    }

    void OnDisable()
    {
        if (score > highScore)
        {
            PlayerPrefs.SetInt(highScoreKey, score);
            PlayerPrefs.Save();
        }
    }
}
