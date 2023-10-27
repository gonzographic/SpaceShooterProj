using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHealthPickups : MonoBehaviour
{
    [SerializeField] private List<GameObject> pickupSpawns;
    [SerializeField] private HealthPickupPool healthPickup;

    private float spawnInterval;
    private float spawnTimer;

    void Start()
    {
        spawnInterval = 15;
        spawnTimer = 0;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            var newHealthPickup = healthPickup.GetHealthPickup();

            if (newHealthPickup != null)
            {
                var randSpawn = Random.Range(0, pickupSpawns.Count);
                newHealthPickup.transform.position = pickupSpawns[randSpawn].transform.position;
            }

            for (int i = 0; i < healthPickup.GetHealthPickups.Count; i++)
            {
                newHealthPickup.SetActive(true);
            }
            spawnTimer = spawnInterval;
        }
    }
}
