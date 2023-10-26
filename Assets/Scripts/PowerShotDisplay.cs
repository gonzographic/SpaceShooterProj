using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PowerShotDisplay : MonoBehaviour
{
    [SerializeField] private Image backGround;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private Color greenGo;
    [SerializeField] private Color yellowNo;

    private void Update()
    {
        if (timeText.text != "RDY")
        {
            timeText.color = yellowNo;
            //backGround.color = yellowNo;
        }
        else if (timeText.text == "RDY")
        {
            timeText.color = greenGo;
            //backGround.color = greenGo;
        }
    }
}
