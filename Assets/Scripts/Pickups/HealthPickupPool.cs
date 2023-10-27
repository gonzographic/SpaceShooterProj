using System.Collections.Generic;
using UnityEngine;

public class HealthPickupPool : MonoBehaviour
{
    [SerializeField] private GameObject healthPickup;

    private List<GameObject> healthPickups;
    public List<GameObject> GetHealthPickups => healthPickups;

    private int amountOfHealthPickups;

    private void Start()
    {
        healthPickups = new List<GameObject>();

        amountOfHealthPickups = 1;

        for (int i = 0; i < amountOfHealthPickups; i++)
        {
            healthPickups.Add(Instantiate(healthPickup, transform));
            healthPickups[i].SetActive(false);
        }
    }

    public GameObject GetHealthPickup()
    {
        for (int i = 0; i < amountOfHealthPickups; i++)
        {
            if (!healthPickups[i].activeInHierarchy)
            {
                return healthPickups[i];
            }
        }

        var newHealthPickup = Instantiate(healthPickup, transform);
        healthPickup.gameObject.SetActive(false);
        healthPickups.Add(newHealthPickup);

        return newHealthPickup;
    }
}
