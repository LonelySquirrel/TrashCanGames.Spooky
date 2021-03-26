using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    //Linus kod
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menu)
            {
                menu.SetActive(true);
                Time.timeScale = 0f;
            }
            else if (menu == true)
            {
                menu.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

}
