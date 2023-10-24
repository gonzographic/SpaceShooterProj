using UnityEngine;

[CreateAssetMenu(fileName = "TurretBase", menuName = "ScriptableObjects/TurretBase")]
public class TurretSO : ScriptableObject
{
    [SerializeField] private float unitFireSpeed;

    public float GetFireSpeed => unitFireSpeed;
}
