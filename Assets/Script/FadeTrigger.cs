using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeTrigger : MonoBehaviour
{
    public RoomChange FadeOut;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FadeOut.FadeOut();
        }
        Invoke("loadScene", 2);
    }
    void loadScene()
    {
        SceneManager.LoadScene(3);
    }
}
