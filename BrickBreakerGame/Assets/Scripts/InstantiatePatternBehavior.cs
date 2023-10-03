using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPatternGenerator : MonoBehaviour
{
    public GameObject[] objectPrefabs; // an array to store different object prefabs to be spawned
    public float spawnRadius = 10f; // the maximum radius objects can be spawned
    public int maxObjects = 10; // the maximum number of objects to be spawned

    void Start()
    {
        GeneratePattern();
    }

    void GeneratePattern()
    {
        for (int i = 0; i < maxObjects; i++)
        {
            int randomIndex = Random.Range(0, objectPrefabs.Length); // get a random index for objectPrefabs array
            Vector3 randomPosition = Random.insideUnitSphere * spawnRadius; // generate a random position within the spawn radius
            
            Instantiate(objectPrefabs[randomIndex], randomPosition, Quaternion.identity); // spawn the random object at the random position
        }
    }
}

