using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    private Queue<string> sentences; // Skapar en Queue för X antal meningar.
    public TMP_Text text;
    public Image textBox;
    public Button continueButton;
    private bool textActive;
    void Start()
    {
        sentences = new Queue<string>();    //Där du väljer nya strings till Queue.
        textActive = false;
        continueButton.enabled = false;
    }
    private void Update()
    {
        if(textActive == false) 
        { text.text = " "; // gömmer text rutan ifall man är ur en konversation
            textBox.enabled = false; 
            continueButton.enabled = false;
        }
        else { textBox.enabled = true; // aktiverar text rutan igen när man går in på en konversation. 
            continueButton.enabled = true;  
              }
    }
    public void StartDialogue(Dialog dialogue) 
    {

        Debug.Log("Starting conversation with " + dialogue.name); // Tar "name" från dialog och gör den till en convesations inledare.
        sentences.Clear(); // rensar dom gammla meningarna och gör plats för nästa i Queue.

        foreach (string sentance in dialogue.sentence) 
        {
            sentences.Enqueue(sentance); //Lägger till meningar till Queue
        }
        DisplayNextSentance(); // Tar bort den "Sentence" som ligger längst fram och därefter så hamnar 2an först. Om det inte finns någon "Sentence" efter så avslutas dialogen.
            
    }
    public void DisplayNextSentance() 
    { 
        if(sentences.Count == 0 ) // om antalet meningar i "Queue" är == 0 så avslutas dialogen. 
        {   
            EndDialogue();
            textActive = false;
            textBox.enabled = false;
            continueButton.enabled = false;
            return;
        }
        else 
        {
            textActive = true;
        }
        
        string sentances = sentences.Dequeue(); // Tar bort den mening som ligger längst fram och ersätter den men näst kommande.
        Debug.Log(sentances); // skriver ut den nya 1an på Queue
        text.text = sentances;
    }
    void EndDialogue() 
    {
        Debug.Log("The conversation ends here..."); //skriver ut att konversationen tar slut.
    }
}
