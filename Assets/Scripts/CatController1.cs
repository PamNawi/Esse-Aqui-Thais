using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController1 : PlayerController{

    public GameObject nails;

	// Use this for initialization
	protected override void Start () {
        base.Start();
        nails = transform.Find("Nails").gameObject ;
    }

    protected override void OtherCommands(){
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Unhas!");
            nails.SetActive(true);
        }
        else {
            nails.SetActive(false);
        }
        
    }

}
