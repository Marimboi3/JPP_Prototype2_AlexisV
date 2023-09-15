using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour
{
    private float lives = 3;
    private float score = 0;
    private float lastScore = 0;
    private float lastLives = 3;
    public GameObject Food;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"You have {lives} lives and a score of {score}.");
        Debug.Log("Lives = " + lives);
        Debug.Log("Score = " + score);
    }

    // Update is called once per frame
    void Update()
    {
        if (score != lastScore)
        {
            Debug.Log("Score = " + score);
        }
        lastScore = score;

        if (lives != lastLives)
        {
            Debug.Log("Lives = " + lives);
        }
        lastLives = lives;

    }



    public float getScore()
    {
        return score;
    }

    public void setScore(float num)
    {
        score = num;
    }

    public float getLives()
    {
        return lives;
    }

    public void setLives(float num)
    {
        lives = num;
    }
}
