using System.Collections.Generic;
using UnityEngine;

public class TurretPool : MonoBehaviour
{
    [SerializeField] private GameObject mTurret = null;

    private List<GameObject> mTurrets;
    private int mAmountOfTurrets;

    public List<GameObject> GetTurrets => mTurrets;

    private void Start()
    {
        mTurrets = new List<GameObject>();
        mAmountOfTurrets = 8;

        for (int i = 0; i < mAmountOfTurrets; i++)
        {
            mTurrets.Add(Instantiate(mTurret, transform));
            mTurrets[i].SetActive(false);
        }
    }

    public GameObject GetTurret()
    {
        for (int i = 0; i < mAmountOfTurrets; i++)
        {
            if (!mTurrets[i].activeInHierarchy)
            {
                return mTurrets[i];
            }
        }

        var newTurret = Instantiate(mTurret, transform);
        mTurret.gameObject.SetActive(false);
        mTurrets.Add(newTurret);

        return newTurret;
    }
}
