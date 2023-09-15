using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject leftSide;
    public GameObject rightSide;
    private float spawnRangeX = 20;
    private float upperZSpawn = 15;
    private float lowerZSpawn = -3;
    private float spawnPosX = 30;
    private float spawnPosZ = 35;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex1 = Random.Range(0, animalPrefabs.Length);
        int animalIndex2 = Random.Range(0, animalPrefabs.Length);
        int animalIndex3 = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPosUp = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPosLeft = new Vector3(-spawnPosX, 0, Random.Range(lowerZSpawn, upperZSpawn));
        Vector3 spawnPosRight = new Vector3(spawnPosX, 0, Random.Range(lowerZSpawn, upperZSpawn));

        Instantiate(animalPrefabs[animalIndex1], spawnPosUp, animalPrefabs[animalIndex1].transform.rotation);
        Instantiate(animalPrefabs[animalIndex2], spawnPosLeft, leftSide.transform.rotation);
        Instantiate(animalPrefabs[animalIndex3], spawnPosRight, rightSide.transform.rotation);

    }
}
