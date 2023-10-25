using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "BackgroundScrollBase", menuName = "ScriptableObjects/BackgroundScrollBase")]
public class BackgroundScrollSO : ScriptableObject
{
    [SerializeField] private Texture backgroundImage;
    [SerializeField] private float scrollSpeed;
    [SerializeField] private Color imageTint;

    public float GetScrollSpeed => scrollSpeed;
    public Texture GetBackgroundImage => backgroundImage;
    public Color GetImageTint => imageTint;
}
