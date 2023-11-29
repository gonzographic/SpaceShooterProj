using TMPro;
using UnityEngine;

public class TurretText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI mKillText = null;

    private int mCurrentKills;

    public int GetturretKills => mCurrentKills;

    private void Start()
    {
        mCurrentKills = 0;
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
            mCurrentKills = 0;
            mKillText.text = mCurrentKills.ToString();
        }
        else
        {
            mCurrentKills += amount;
            mKillText.text = mCurrentKills.ToString();
        }
    }
}
