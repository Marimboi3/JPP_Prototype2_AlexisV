using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameObject UI;
    private GameObject prefab;
/*    private float foxHealth = 1;
    private float mooseHealth = 3;
    private float dogHealth = 2;*/
    private float currentHealth;
    private UserInterface gameManager;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        prefab = this.gameObject;
        UI = GameObject.Find("UI");

        gameManager = GameObject.Find("UI").GetComponent<UserInterface>();

        /*if (prefab.name == "Fox")
        {
            currentHealth = foxHealth;
        }
        else if (prefab.name == "Moose")
        {
            currentHealth = mooseHealth;
        }
        else if (prefab.name == "Dog")
        {
            currentHealth = dogHealth;
        }

        healthBar.SetMaxHealth(currentHealth);*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Food") && other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        if (other.CompareTag("Animals"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
            /*if (prefab.name == "Fox")
            {
                TakeDamage(1);
            }
            float score = UI.GetComponent<UserInterface>().getScore() + 1;

            UI.GetComponent<UserInterface>().setScore(score);
            Destroy(other.gameObject);
            Destroy(gameObject);*/
        }

/*        if (prefab.CompareTag("Player") && !other.CompareTag("Food"))
        {
            Debug.Log("Youve been hit!");
            float lives = UI.GetComponent<UserInterface>().getLives() - 1;

            UI.GetComponent<UserInterface>().setLives(lives);
            Destroy(other.gameObject);
            if (lives == 0)
            {
                Destroy(gameObject);
                Debug.Log("GAME OVER!");
            }
        }*/
    }
}
