using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PowerShotDisplay : MonoBehaviour
{
    [SerializeField] private Image mBackground = null;
    [SerializeField] private TextMeshProUGUI mTimeText = null;
    [SerializeField] private Color mGreenGo = Color.white;
    [SerializeField] private Color mYellowNo = Color.white;

    private void Update()
    {
        if (mTimeText.text != "RDY")
        {
            mTimeText.color = mYellowNo;
        }
        else if (mTimeText.text == "RDY")
        {
            mTimeText.color = mGreenGo;
        }
    }
}
