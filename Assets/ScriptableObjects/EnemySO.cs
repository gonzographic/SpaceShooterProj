using UnityEngine;

[CreateAssetMenu(fileName = "EnemyBase", menuName = "ScriptableObjects/EnemyBase")]
public class EnemySO : ScriptableObject
{
    [SerializeField] private string unitName;
    [SerializeField] private Animator unitAnimationController;
    [SerializeField] private float unitMaxLife;
    [SerializeField] private float unitSpeed;
    [SerializeField] private float unitFireSpeed;
    [SerializeField] private float unitMaxShield;
}
