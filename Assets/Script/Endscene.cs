﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Endscene : MonoBehaviour
{
    public GameObject Hjalmar;
    public GameObject Cristian;
    public GameObject Emil;
    public GameObject Linus;

    public GameObject Kaylei;
    public GameObject Madelene;
    // Start is called before the first frame update
    void Start()
    {
        Hjalmar.SetActive(false);
        Cristian.SetActive(false);
        Emil.SetActive(false);
        Linus.SetActive(false);
        Kaylei.SetActive(false);
        Madelene.SetActive(false);
    }

    public void hjalmar()
    {
        Hjalmar.SetActive(true);
        Cristian.SetActive(false);
        Emil.SetActive(false);
        Linus.SetActive(false);
        Kaylei.SetActive(false);
        Madelene.SetActive(false);
    }
    public void cristian()
    {
        Hjalmar.SetActive(false);
        Cristian.SetActive(true);
        Emil.SetActive(false);
        Linus.SetActive(false);
        Kaylei.SetActive(false);
        Madelene.SetActive(false);
    }
    public void emil()
    {
        Hjalmar.SetActive(false);
        Cristian.SetActive(false);
        Emil.SetActive(true);
        Linus.SetActive(false);
        Kaylei.SetActive(false);
        Madelene.SetActive(false);
    }
    public void linus()
    {
        Hjalmar.SetActive(false);
        Cristian.SetActive(false);
        Emil.SetActive(false);
        Linus.SetActive(true);
        Kaylei.SetActive(false);
        Madelene.SetActive(false);
    }
    public void kaylei()
    {
        Hjalmar.SetActive(false);
        Cristian.SetActive(false);
        Emil.SetActive(false);
        Linus.SetActive(false);
        Kaylei.SetActive(true);
        Madelene.SetActive(false);
    }
    public void madelene()
    {
        Hjalmar.SetActive(false);
        Cristian.SetActive(false);
        Emil.SetActive(false);
        Linus.SetActive(false);
        Kaylei.SetActive(false);
        Madelene.SetActive(true);
    }
}
