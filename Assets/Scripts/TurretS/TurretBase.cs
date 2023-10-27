using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBase : MonoBehaviour
{
    [SerializeField] private TurretSO turretData;
    [SerializeField] private GameObject explosion;

    private float currentHealth;

    private void Start()
    {
        currentHealth = turretData.GetHealth;
    }

    private void Update()
    {
        transform.position -= new Vector3(0, (turretData.GetMoveSpeed * Time.deltaTime), 0);

        if (currentHealth <= 0)
        {
            Actions.KillCount?.Invoke(1);
            Instantiate(explosion, transform.position, transform.rotation);
            TurretDie();
        }
    }

    private void TurretDie()
    {
        gameObject.SetActive(false);
        currentHealth = turretData.GetHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            currentHealth -= 1;
            collision.gameObject.SetActive(false);
        }
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
        currentHealth = turretData.GetHealth;
    }
}
