using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemName : MonoBehaviour
{
    [SerializeField]
    GameObject TextBox;
    [SerializeField]
    Text TextItem;


    public void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);// -) Läser av var positionen på musen är
        transform.position = new Vector2(cursorPos.x, cursorPos.y + 0.5f);// flyttar canvasen till positonen av musen
        RaycastHit2D hit = Physics2D.Raycast(cursorPos, Vector2.zero); // en 2d raycast på musens position
        if (hit.collider != null)
        {
            
            TextItem.gameObject.SetActive(true);// Skapar texten som ska stå när musen är över
            TextItem.text = hit.transform.name;// säger namnet på objektet
        }
        else
        {
            TextItem.gameObject.SetActive(false);// stänger av texten
        }
    }
    //-) Hjalmar Heike
}
