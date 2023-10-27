using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkBoss : MonoBehaviour
{
    [SerializeField] private TurretSO turretData;
    [SerializeField] private GameObject[] laserSpawns;

    private GameObject player;
    private float shootTimer;
    private float currentHealth;

    private void Start()
    {
        currentHealth = turretData.GetHealth;
    }

    private void OnEnable()
    {
        shootTimer = 1.5f;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        shootTimer -= Time.deltaTime;
        TargetPlayer();
        ShootPlayer();

        if (currentHealth <= 0)
        {
            //Instantiate(explosion, transform.position, transform.rotation);
            TurretDie();
        }
    }

    private void TurretDie()
    {
        gameObject.SetActive(false);
        currentHealth = turretData.GetHealth;
    }

    private void ShootPlayer()
    {
        if (shootTimer <= 0)
        {
            var newLaser = EnemyLaserPool.Instance.GetLaserProjectile(); // Get make BOSS LASER POOL
            var newLaserTwo = EnemyLaserPool.Instance.GetLaserProjectile();
            if (newLaser != null)
            {
                newLaser.transform.position = laserSpawns[0].transform.position;
                newLaser.transform.rotation = transform.rotation;
                newLaserTwo.transform.position = laserSpawns[1].transform.position;
                newLaserTwo.transform.rotation = transform.rotation;
            }

            for (int i = 0; i < EnemyLaserPool.Instance.GetLaserProjectiles.Count; i++)
            {
                newLaser.SetActive(true);
                newLaserTwo.SetActive(true);
            }
            //soundEffects.PlayOneShot(laserSound.GetFireSound);
            shootTimer = 1.5f;
        }
    }

    private void TargetPlayer()
    {
        Vector3 rotation = player.transform.position - transform.position;
        float zAxisRotation = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, zAxisRotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            currentHealth -= 1;
            collision.gameObject.SetActive(false);
        }
    }
}
