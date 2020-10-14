using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        LootAngle lootAngle = new LootAngle(45);

        SpawnObject(angle: lootAngle.NextAngle(), radius: 3);
        SpawnObject(angle: lootAngle.NextAngle(), radius: 4);
        SpawnObject(angle: lootAngle.NextAngle(), radius: 5);
        SpawnObject(angle: lootAngle.NextAngle(), radius: 6);
    }

    void SpawnObject(int angle, int radius)
    {
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

public class LootAngle {
    int angle;
    int step;

    public LootAngle(int increment) {
        step = increment;
        angle = 0;
    }
    
    public int NextAngle()
    {
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);
        
        return currentAngle;
    }
}
