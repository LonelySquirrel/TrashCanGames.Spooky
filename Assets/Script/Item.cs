using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    Inventory inventory;
    [SerializeField]
    string itemname;
    [SerializeField]
    Sprite itemSprite;
    [SerializeField]
    GameObject UseButton;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>(); //Hittar tar "Inventory" komponenten från spelaren
    }

    private void OnMouseDown()
    {

    }

    public void Interact()
    {
        print("fucky you");
        for (int i = 0; i < inventory.slots.Length; i++) //Kollar alla slots för en tom ruta
        {
            if (inventory.slotsUsed[i] == false)
            {
                inventory.slotsUsed[i] = true; // Gör att rutan är full
                inventory.slots[i].name = itemname; // Ger namnet till objektet
                inventory.slots[i].GetComponent<Image>().sprite = itemSprite; // Ger Spriten till objektet
                inventory.slots[i].GetComponent<Image>().enabled = true; // Visar Spriten -Christian
                Destroy(gameObject);
                break;

            }

        }
    }


}
