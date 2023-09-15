using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameObject UI;
    private GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        prefab = this.gameObject;
        UI = GameObject.Find("UI");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (prefab.CompareTag("Food") && other.CompareTag("Animals"))
        {
            float score = UI.GetComponent<UserInterface>().getScore() + 1;

            //score++;

            UI.GetComponent<UserInterface>().setScore(score);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (prefab.CompareTag("Player") && !other.CompareTag("Food"))
        {
            Debug.Log("Youve been hit!");
            float lives = UI.GetComponent<UserInterface>().getLives() - 1;

            //score++;

            UI.GetComponent<UserInterface>().setLives(lives);
            Destroy(other.gameObject);
            if (lives == 0)
            {
                Destroy(gameObject);
                Debug.Log("GAME OVER!");
            }
        }
    }
}
