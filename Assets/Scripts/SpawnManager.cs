using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnableJunk;
    private bool spawnonLeft = true;
    private float topSpawnPosition = 15;
    private float bottomSpawnPosition = 2;
    private float xSpawnPosition = 23;
    private float zRange = 5;
    private float startSpawn = 2;
    private float spawnInterval = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnJunk", startSpawn, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnJunk()
    {
        int junkIndex = Random.Range(0, spawnableJunk.Length);
        int spawnPoint = Random.Range(0, 2);
        spawnonLeft = spawnPoint == 0;

        Vector3 spawnPosition = new Vector3(spawnonLeft ? -xSpawnPosition : xSpawnPosition, Random.Range(bottomSpawnPosition, topSpawnPosition), Random.Range(-zRange, zRange));

        Instantiate(spawnableJunk[junkIndex], spawnPosition, spawnableJunk[junkIndex].transform.rotation);
    }
}
