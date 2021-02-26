using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialog dialogue) 
    {
        Debug.Log("Starting conversation with " + dialogue.name);
        sentences.Clear();

        foreach (string sentance in dialogue.sentence) 
        {
            sentences.Enqueue(sentance);
        }
        DisplayNextSentance();
            
    }
    public void DisplayNextSentance() 
    { 
        if(sentences.Count == 0 )
        {   
            EndDialogue();
            return;
        }
        string sentances = sentences.Dequeue();
        Debug.Log(sentances);
    }
    void EndDialogue() 
    {
        Debug.Log("The conversation ends here...");
    }
}
