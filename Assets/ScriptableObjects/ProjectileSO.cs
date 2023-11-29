using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileBase", menuName = "ScriptableObjects/ProjectileBase")]
public class ProjectileSO : ScriptableObject
{
    [SerializeField] private AudioClip mFireSound = null;
    [SerializeField] private float mSpeed = 0.0f;

    public AudioClip GetFireSound => mFireSound;
    public float GetSpeed => mSpeed;
}