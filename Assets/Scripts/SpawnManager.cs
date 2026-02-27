using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;

    void Start()
    {
        InvokeRepeating("Spawn", 0, 2.0f);
        
    }

    private void Update()
    {

    }

    void Spawn()
    {
        Instantiate(
            obstaclePrefab,
            spawnPoint.position,
            obstaclePrefab.transform.rotation
        );
    }
}
