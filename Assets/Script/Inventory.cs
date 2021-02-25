using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    Animator Opens;
    [SerializeField]
    Animator Closes;
    public bool isopen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isopen == false)
        {
            if(Input.GetKeyDown(KeyCode.Tab))
            {
                Open();
                isopen = true;
            }
        }
        else if (isopen == true)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                Close();
                isopen = false;
            }
            
        }
    }

    void Open()
    {
        print("Opening");
        Opens.SetTrigger("Open");
    }
    void Close()
    {
        print("Closeing");
        Closes.SetTrigger("Close");
    }
}

