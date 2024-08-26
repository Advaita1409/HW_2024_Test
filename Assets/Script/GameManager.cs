using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject pulpitPrefab;
    public float minSpawnTime;
    public float maxSpawnTime;
    public float minLifeTime;
    public float maxLifeTime;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        // Load JSON data here and set the variables
    }

    void Start()
    {
        StartCoroutine(SpawnPulpits());
    }

    IEnumerator SpawnPulpits()
    {
        while (true)
        {
            SpawnPulpit();
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        }
    }

    void SpawnPulpit()
    {
        Vector3 spawnPosition = GetValidSpawnPosition();
        GameObject pulpit = Instantiate(pulpitPrefab, spawnPosition, Quaternion.identity);
        float lifeTime = Random.Range(minLifeTime, maxLifeTime);
        pulpit.GetComponent<PulpitController>().SetLifeTime(lifeTime);
    }

    Vector3 GetValidSpawnPosition()
    {
        // Implement logic to get a valid spawn position adjacent to the previous pulpit
    }
}
