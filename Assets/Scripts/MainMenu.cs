using UnityEditor;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mThisScreen = null;
    [SerializeField] private GameObject mPlayScreen = null;
    [SerializeField] private GameObject mPlayScreenUI = null;
    [SerializeField] private GameObject mManagers = null;
    [SerializeField] private GameObject mPlayer = null;
    [SerializeField] private AudioSource mThisMusic = null;

    private void Start()
    {
        mThisMusic.Play();
    }

    public void ClickStartGame()
    {
        mThisMusic.Stop();
        mThisScreen.SetActive(false);
        mManagers.SetActive(true);
        mPlayScreen.SetActive(true);
        mPlayScreenUI.SetActive(true);
        mPlayer.SetActive(true);
    }

    public void ClickExitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false; // Remove before building the game
    }
}
