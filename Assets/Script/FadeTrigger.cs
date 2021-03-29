using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    
    public RoomChange FadeOut;
    public Transform TargetPonit;// vart  kommer när man öpnar dören
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                FadeOut.FadeOut();
                Invoke("Fadein", 1);
                
            }
            
        }
        
    }
    private void Opendoor()
    {
        Player.transform.position = TargetPonit.position;
    }

    void Fadein()
    {
        FadeOut.FadeIN();
        Opendoor();
    }
}
