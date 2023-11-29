using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserPool : MonoBehaviour
{
    [SerializeField] private GameObject mLaserProjectile = null;

    private List<GameObject> mLaserProjectiles;
    private int mAmountOfLaserProjectiles;

    public List<GameObject> GetLaserProjectiles => mLaserProjectiles;

    private void Start()
    {
        mLaserProjectiles = new List<GameObject>();
        mAmountOfLaserProjectiles = 50;

        for (int i = 0; i < mAmountOfLaserProjectiles; i++)
        {
            mLaserProjectiles.Add(Instantiate(mLaserProjectile, transform));
            mLaserProjectiles[i].SetActive(false);
        }
    }

    public GameObject GetLaserProjectile()
    {
        for (int i = 0; i < mAmountOfLaserProjectiles; i++)
        {
            if (!mLaserProjectiles[i].activeInHierarchy)
            {
                return mLaserProjectiles[i];
            }
        }

        var newLaser = Instantiate(mLaserProjectile, transform);
        mLaserProjectile.gameObject.SetActive(false);
        mLaserProjectiles.Add(newLaser);

        return newLaser;
    }
}
