using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] private RawImage background;
    [SerializeField] private float verticalSpeed;

    void Update()
    {
        background.uvRect = new Rect(background.uvRect.position + new Vector2(verticalSpeed,0) * Time.deltaTime, background.uvRect.size);
    }
}
