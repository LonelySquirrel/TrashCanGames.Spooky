using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject Easy;
    public GameObject Hard;
    //Linus
    //These all simply load certain scenes when you press a button

    public void Start()
    {
        Easy.SetActive(false);
        Hard.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        SceneManager.LoadScene(1);
    }
    public void back()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void selectEasy()
    {
        Easy.SetActive(true);
        Hard.SetActive(false);
    }

    public void selectHard()
    {
        Hard.SetActive(true);
        Easy.SetActive(false);
    }
}
