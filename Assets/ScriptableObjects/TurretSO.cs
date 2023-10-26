using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "TurretBase", menuName = "ScriptableObjects/TurretBase")]
public class TurretSO : ScriptableObject
{
    [SerializeField] private float rateOfFire;
    [SerializeField] private float health;
    [SerializeField] private GameObject projectileUsed;
    [SerializeField] private float moveSpeed;
    [SerializeField] private EnemyLaserPool laser;

    public float GetRateOfFire => rateOfFire;
    public float GetHealth => health;
    public GameObject GetProjectileUsed => projectileUsed;
    public float GetMoveSpeed => moveSpeed;
    public EnemyLaserPool GetLaserPool => laser;
}
