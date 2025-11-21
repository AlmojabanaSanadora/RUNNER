using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public GameObject roadPrefab;    // Prefab de carretera
    public float spawnRate = 1.2f;   // Cada cuánto aparece una nueva
    public Transform pointA;         // Punto donde se spawnea

    void Start()
    {
        InvokeRepeating(nameof(SpawnRoad), 0f, spawnRate);
    }

    void SpawnRoad()
    {
        Instantiate(roadPrefab, pointA.position, Quaternion.identity);
    }
}
