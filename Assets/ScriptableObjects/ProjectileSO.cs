using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileBase", menuName = "ScriptableObjects/ProjectileBase")]
public class ProjectileSO : ScriptableObject
{
    [SerializeField] private AudioClip fireSound;
    [SerializeField] private float travelSpeed;

    public AudioClip GetFireSound => fireSound;
    public float GetTravelSpeed => travelSpeed;
}
