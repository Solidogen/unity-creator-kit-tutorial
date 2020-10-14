using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        SpawnObject(angle: 0, radius: 3);
        SpawnObject(angle: 45, radius: 4);
        SpawnObject(angle: 90, radius: 5);
        SpawnObject(angle: 180, radius: 6);
    }

    void SpawnObject(int angle, int radius)
    {
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

