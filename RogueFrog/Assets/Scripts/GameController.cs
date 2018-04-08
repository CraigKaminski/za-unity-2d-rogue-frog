using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Player player;
    public Text scoreText;
    public Text levelText;

    private float highestPosition;
    private int score = 0;
    private int level = 1;

	// Use this for initialization
	void Start () {
        player.OnPlayerMoved += OnPlayerMoved;
        player.OnPlayerEscaped += OnPlayerEscaped;

        highestPosition = player.transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnPlayerMoved()
    {
        if (player.transform.position.y > highestPosition)
        {
            highestPosition = player.transform.position.y;
            score++;
            scoreText.text = "Score: " + score;
        }
    }

    void OnPlayerEscaped()
    {
        highestPosition = player.transform.position.y;
        level++;
        levelText.text = "Level: " + level;
    }
}
