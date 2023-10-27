using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TryAgain : MonoBehaviour
{
    [SerializeField] private GameObject thisScreen;
    [SerializeField] private GameObject playScreen;
    [SerializeField] private GameObject playScreenUI;
    [SerializeField] private GameObject managers;
    [SerializeField] private GameObject player;

    public void ClickStartGame()
    {
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
