using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variable creation
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 20;
    public float zRangeLow = 3;
    public float zRangeHigh = 15;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if players position is less than -xRange then move to the left
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // if player position is more than xRange then move to the right
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRangeLow)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRangeLow);
        }

        if (transform.position.z > zRangeHigh)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeHigh);
        }

        // equal the input to variable
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
