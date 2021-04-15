using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    
    public RoomChange FadeOut;// den svarta bilden som kommer när man ska bytta Rum/ Scene
    public Transform TargetPonit;// vart  kommer när man öpnar dören
    private DialogueTrigger Trigger;

    public string KeyName;
    // kollar vad namnet på nyckelns som behöves för att öpnna vissa dörar
    Inventory inventory;

    public bool isLocked;// Bestämer om dören är låst
    // Start is called before the first frame update
    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    // Update is called once per frame

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {// kollar så att spelaren är vid dörren
            if (Input.GetKeyDown(KeyCode.E))// Kollar om spelaren klickar på F innan den aktiverar rästen av koden
            {
                FadeOut.FadeOut();
                Invoke("Fadein", 1);// Gör så att Spelet väntar innan spelaren teleporteras till sin punkt
                
            }
            
        }
        
    }
    private void Opendoor()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {// kollar efter nycklar i dit inventory
            if (inventory.slots[i].name == KeyName)
            {// kollar om du har nyckeln som behövs för dören
                isLocked = false;
            }
        }
        if (isLocked == true)
        {
            FindObjectOfType<DialogueTrigger>();
        }
        
        if (isLocked == false)
        {
            Player.transform.position = TargetPonit.position;// teleporterar spelaren till en annan plats på världen
        }

        
    }

    void Fadein()
    {
        FadeOut.FadeIN();// styr hur den svarta boxen är och när dden ska hända.
        Opendoor();
    }
    // Hjalmar Heike.
}
