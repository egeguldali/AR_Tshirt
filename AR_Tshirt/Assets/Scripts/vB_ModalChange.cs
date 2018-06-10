using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vB_ModalChange : MonoBehaviour, IVirtualButtonEventHandler {


    public GameObject vbBtnObj;
    public GameObject kemikler;
    public GameObject dolasim;
    public GameObject kaslar;
    public GameObject organlar;


	// Use this for initialization
	void Start () {

        //vbBtnObj = GameObject.Find("Kemik_Button");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

       // kemikler = GameObject.Find("Kemik");
        //dolasim = GameObject.Find("Dolasim");

    }
	
    public void OnButtonPressed (VirtualButtonBehaviour vb1)
    {
        Debug.Log("Button Pressed");
        kemikler.SetActive(true);
        dolasim.SetActive(false);
        kaslar.SetActive(false);
        organlar.SetActive(false);
    }


    public void OnButtonReleased (VirtualButtonBehaviour vb1)
    {
        
    }


    // Update is called once per frame
    void Update () {
		
	}
}
