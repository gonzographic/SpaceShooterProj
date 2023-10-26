using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScrolling : MonoBehaviour
{
    [SerializeField] private RawImage backgroundImage;

    private void Update()
    {
        backgroundImage.uvRect = new Rect(backgroundImage.uvRect.position + new Vector2(0.1f, 0) * Time.deltaTime, backgroundImage.uvRect.size);
    }
}
