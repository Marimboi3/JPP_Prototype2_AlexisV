using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delay;
    private float timer = 100;

    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer > delay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0;
        }

        timer += Time.deltaTime;
        Debug.Log(timer);
    }
}
