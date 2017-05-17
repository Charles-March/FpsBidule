using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public GameObject doorOpen;
    public GameObject doorClosed;
    public bool isLocked = true;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Interact()
    {
        if (doorOpen.activeSelf)
        {
            doorOpen.SetActive(false);
            doorClosed.SetActive(true);
        }
        else
        {
            doorOpen.SetActive(true);
            doorClosed.SetActive(false);
        }
    }
}
