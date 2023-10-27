using TMPro;
using UnityEngine;

public class TurretText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI killText;

    private int currentKills;

    public int GetturretKills => currentKills;

    private void Start()
    {
        killText.text = "0";
    }

    private void OnEnable()
    {
        Actions.KillCount += AddScore;
    }

    private void OnDisable()
    {
        Actions.KillCount -= AddScore;
    }

    public void AddScore(int amount)
    {
        if (amount == 0)
        {
            currentKills = 0;
            killText.text = currentKills.ToString();
        }
        else
        {
            currentKills += amount;
            killText.text = currentKills.ToString();
        }
    }
}
