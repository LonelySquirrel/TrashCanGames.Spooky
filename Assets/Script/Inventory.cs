using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] // (
    Animator Opens; //
    [SerializeField] //
    Animator Closes; //
    public bool isopen = false; // ) -Hjalmar

    //De är public så att andra scripts har tillgång till dem.
    public bool[] slotsUsed; // ( Kollar om sloten är full.
    public GameObject[] slots; // ) -Christian
  
    void Update()
    {
        Opens.SetBool("IsOpen", isopen);
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isopen == false)// Byter mellan att ha menyn öppen och stängd
            {
                print("Opening"); //debug

                isopen = true;
            }
            else if (isopen == true)
            {
                print("Closing"); //debug

                isopen = false;

            }
        }
        
        // ) -Christian
    }

    /*void Open() // -Hjalmar
    {
        print("Opening");
        Opens.SetBool("IsOpen", true);
    }
    void Close() // -Hjalmar
    {
        print("Closeing");
        Closes.SetBool("IsOpen");
    }*/
}

