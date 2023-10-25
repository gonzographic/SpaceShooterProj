using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] private BackgroundScrollSO scrollData;
    [SerializeField] private RawImage backgroundImage;

    private void Start()
    {
        backgroundImage.texture = scrollData.GetBackgroundImage;
        backgroundImage.color = scrollData.GetImageTint;
    }
    private void Update()
    {
        backgroundImage.uvRect = new Rect(backgroundImage.uvRect.position + new Vector2(scrollData.GetScrollSpeed, 0) * Time.deltaTime, backgroundImage.uvRect.size);
    }
}
