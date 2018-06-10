using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vB_Full : MonoBehaviour, IVirtualButtonEventHandler
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

    public void OnButtonPressed(VirtualButtonBehaviour vb4)
    {
        Debug.Log("Button Pressed");
        kemikler.SetActive(true);
        dolasim.SetActive(true);
        kaslar.SetActive(false);
        organlar.SetActive(true);
    }


    public void OnButtonReleased(VirtualButtonBehaviour vb4)
    {

    }


    // Update is called once per frame
    void Update()
    {

    }
}
