using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private PlayerInputs player;
    [SerializeField] private Image background;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private Color colorFull;
    [SerializeField] private Color colorEighty;
    [SerializeField] private Color colorSixty;
    [SerializeField] private Color colorForty;
    [SerializeField] private Color colorTwenty;
    [SerializeField] private Color colorDead;

    private void Update()
    {
        if (player.GetHealth == 5)
        {
            healthText.text = "100%";
            background.color = colorFull;
        }
        else if (player.GetHealth == 4)
        {
            healthText.text = "80%";
            background.color = colorEighty;
        }
        else if (player.GetHealth == 3)
        {
            healthText.text = "60%";
            background.color = colorSixty;
        }
        else if (player.GetHealth == 2)
        {
            healthText.text = "40%";
            background.color = colorForty;
        }
        else if (player.GetHealth == 1)
        {
            healthText.text = "20%";
            background.color = colorTwenty;
        }
        else if (player.GetHealth == 0)
        {
            healthText.text = "0%";
            background.color = colorDead;
        }
    }
}
