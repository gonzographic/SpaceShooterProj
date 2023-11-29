using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] private BackgroundScrollSO mScrollData = null;
    [SerializeField] private RawImage mBackgroundImage = null;

    private void Start()
    {
        mBackgroundImage.texture = mScrollData.GetBackgroundImage;
        mBackgroundImage.color = mScrollData.GetImageTint;
    }
    private void Update()
    {
        mBackgroundImage.uvRect = new Rect(mBackgroundImage.uvRect.position + new Vector2(mScrollData.GetScrollSpeed, 0) * Time.deltaTime, mBackgroundImage.uvRect.size);
    }
}
