using UnityEditor;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject thisScreen;
    [SerializeField] private GameObject playScreen;
    [SerializeField] private GameObject playScreenUI;
    [SerializeField] private GameObject managers;
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource thisMusic;

    private void Start()
    {
        thisMusic.Play();
    }

    public void ClickStartGame()
    {
        thisMusic.Stop();
        thisScreen.SetActive(false);
        managers.SetActive(true);
        playScreen.SetActive(true);
        playScreenUI.SetActive(true);
        player.SetActive(true);
    }

    public void ClickExitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false; // Remove before building the game
    }
}
