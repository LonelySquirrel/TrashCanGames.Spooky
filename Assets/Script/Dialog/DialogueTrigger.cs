using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{   
    public Dialog dialog;   //Tar data typen dialog och implementerar på dialog triggern vilket låter oss lägga trigger på ett objekt och skräddarsy en dialog.

    public void TriggerDialogue() 
    {
        FindObjectOfType<DialogManager>().StartDialogue(dialog);    // Om någon "triggar" en dialog så startar StartDialogue funktionen igång.
    }
}
