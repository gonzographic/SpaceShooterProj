using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    [SerializeField] private TurretSO turretData;
    [SerializeField] private GameObject laserSpawnOne;

    private GameObject player;
    private float shootTimer;

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
    }

    private void ShootPlayer()
    {
        if (shootTimer <= 0)
        {
            var newLaser = EnemyLaserPool.Instance.GetLaserProjectile();
            if (newLaser != null)
            {
                newLaser.transform.position = laserSpawnOne.transform.position;
                newLaser.transform.rotation = transform.rotation;
            }

            for (int i = 0; i < EnemyLaserPool.Instance.GetLaserProjectiles.Count; i++)
            {
                newLaser.SetActive(true);
            }
            //soundEffects.PlayOneShot(laserSound.GetFireSound);
            shootTimer = 1.5f;
        }
    }

    private void TargetPlayer()
    {
        Vector3 rotation = player.transform.position - transform.position;
        float zAxisRotation = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, zAxisRotation - 90);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            ShootPlayer();
        }
    }
}
