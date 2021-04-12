using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomChange : MonoBehaviour
{
    public Image FadeO;
    
    // Start is called before the first frame update
    void Start()
    {
        FadeO.canvasRenderer.SetAlpha(1.0f);
        FadeIN();// gör så att den svarta boxen blir transparant
        
    }

    // Update is called once per frame
  
    public void FadeIN()
    {
        FadeO.CrossFadeAlpha(0, 1, false);// styr när bilden ska bli transparant
    }
    public void FadeOut()
    {
        FadeO.CrossFadeAlpha(1, 1, false);// Styr när och hur lång tid det tar för bilden att bli hel igen.
    }
}//HJalmar Heike
