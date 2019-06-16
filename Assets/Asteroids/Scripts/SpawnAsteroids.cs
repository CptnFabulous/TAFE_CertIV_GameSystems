using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour {




    /*
    public struct Asteroids
    {
        public GameObject asteroid;
        public float velocity;
        public float spawnRate;
    }
    */

    public GameObject[] asteroids;

    public float spawnRate;
    public float spawnRadius;

    float spawnTimer;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, spawnRadius);
    }

    void Spawn()
    {

        /*
        Vector2 rand = Random.insideUnitCircle * spawnRadius; //Randomize a position
        Vector2 position = (Vector2)transform.position + rand; // Offset position from spawner location
        int randIndex = Random.Range(0, asteroidPrefabs.Length); // Generate a random index into prefab array
        GameObject randAsteroid = asteroidPrefabs[randIndex]; // Get random asteroid using index
        Instantiate(randAsteroid, position, Quaternion.identity); // Clone random asteroid - Quaternion.identity means default rotation (0) // Makes a copy and puts in scene 
        */


        //Vector3 rand = Random.insideUnitSphere * spawnRadius;

        //Vector2 spawnLocation = Random.insideUnitCircle * spawnRadius;

        Vector2 spawnLocation = (Vector2)transform.position + (Random.insideUnitCircle * spawnRadius);

        GameObject randomAsteroid = Instantiate(asteroids[Random.Range(0, asteroids.Length)], spawnLocation, Quaternion.identity);


    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnRate)
        {
            Spawn();
            spawnTimer = 0;
        }
	}
}
