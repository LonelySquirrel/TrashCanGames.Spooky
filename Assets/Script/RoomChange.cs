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
        FadeIN();
        
    }

    // Update is called once per frame
  
    void FadeIN()
    {
        FadeO.CrossFadeAlpha(0, 1, false);
    }
    public void FadeOut()
    {
        FadeO.CrossFadeAlpha(1, 1, false);
    }
}
