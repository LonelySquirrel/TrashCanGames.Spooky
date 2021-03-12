using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog
{
    public string name; //skriver ut namnet på NPC du talar med.

    [TextArea(3,5)]     //Gör textrutan du skriver ner dialogen i trevligare att skriva i. Med andra ord så förstorar den utrymmet du kan skriva på.
    public string[] sentence;   //Själva dialogen(meningarna som skrivs ut). 
}
