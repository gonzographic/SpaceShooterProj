using System.Collections.Generic;
using UnityEngine;

public class TurretPool : MonoBehaviour
{
    [SerializeField] private GameObject turret;

    private List<GameObject> turrets;
    public List<GameObject> GetTurrets => turrets;

    private int amountOfTurrets;

    private void Start()
    {
        turrets = new List<GameObject>();

        amountOfTurrets = 4;

        for (int i = 0; i < amountOfTurrets; i++)
        {
            turrets.Add(Instantiate(turret, transform));
            turrets[i].SetActive(false);
        }
    }

    public GameObject GetTurret()
    {
        for (int i = 0; i < amountOfTurrets; i++)
        {
            if (!turrets[i].activeInHierarchy)
            {
                return turrets[i];
            }
        }

        return null;
    }
}
