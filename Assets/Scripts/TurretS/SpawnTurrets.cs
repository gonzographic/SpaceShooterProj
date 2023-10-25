using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTurrets : MonoBehaviour
{
    [SerializeField] private List<GameObject> turretSpawns;
    [SerializeField] private TurretPool turret;

    private float spawnInterval;
    private float spawnTimer;

    void Start()
    {
        spawnInterval = 3.3f;
        spawnTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        var spawnCount = Random.Range(0, 100);

        if (spawnTimer <= 0 && spawnCount > 50)
        {
            for (int i = 0; i < turretSpawns.Count; i++)
            {
                var newTurret = turret.GetTurret();

                if (newTurret != null)
                {
                    newTurret.transform.position = turretSpawns[i].transform.position;
                }

                for (int j = 0; j < turret.GetTurrets.Count; j++)
                {
                    newTurret.SetActive(true);
                }

            }
            spawnTimer = spawnInterval;
        }
        else if (spawnTimer <= 0)
        {
            var newTurret = turret.GetTurret();

            if (newTurret != null)
            {
                var randSpawn = Random.Range(0, turretSpawns.Count);
                newTurret.transform.position = turretSpawns[randSpawn].transform.position;
            }

            for (int i = 0; i < turret.GetTurrets.Count; i++)
            {
                newTurret.SetActive(true);
            }
            spawnTimer = spawnInterval;
        }
    }
}
