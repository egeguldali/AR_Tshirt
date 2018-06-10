﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vB_Kaslar : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;
    public GameObject kemikler;
    public GameObject dolasim;
    public GameObject kaslar;
    public GameObject organlar;


    // Use this for initialization
    void Start()
    {

        //vbBtnObj = GameObject.Find("Kemik_Button");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        // kemikler = GameObject.Find("Kemik");
        //dolasim = GameObject.Find("Dolasim");

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb3)
    {
        Debug.Log("Button Pressed");
        kemikler.SetActive(false);
        dolasim.SetActive(false);
        kaslar.SetActive(true);
        organlar.SetActive(false);
    }


    public void OnButtonReleased(VirtualButtonBehaviour vb3)
    {

    }


    // Update is called once per frame
    void Update()
    {

    }
}