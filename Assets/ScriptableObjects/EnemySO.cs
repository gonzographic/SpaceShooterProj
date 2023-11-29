using UnityEngine;

[CreateAssetMenu(fileName = "EnemyBase", menuName = "ScriptableObjects/EnemyBase")]
public class EnemySO : ScriptableObject
{
    [SerializeField] private string mName = "";
    [SerializeField] private Animator mAnimator = null;
    [SerializeField] private float mMaxLife = 0.0f;
    [SerializeField] private float mSpeed = 0.0f;
    [SerializeField] private float mShootingSpeed = 0.0f;
    [SerializeField] private float mMaxShield = 0.0f;

    public string GetName => mName;
    public Animator GetAnimator => mAnimator;
    public float GetMaxLife => mMaxLife;
    public float GetSpeed => mSpeed;
    public float GetShootingspeed => mShootingSpeed;
    public float GetMaxShield => mMaxShield;
}