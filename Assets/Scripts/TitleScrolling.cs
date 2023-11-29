using UnityEngine;
using UnityEngine.UI;

public class TitleScrolling : MonoBehaviour
{
    [SerializeField] private RawImage mBackgroundImage = null;

    private void Update()
    {
        mBackgroundImage.uvRect = new Rect(mBackgroundImage.uvRect.position + new Vector2(0.1f, 0) * Time.deltaTime, mBackgroundImage.uvRect.size);
    }
}
