using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_trigger : MonoBehaviour {

    public bool interacting = false;
    public GameObject colliding = null;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	   	
	}

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Interactable" || other.tag == "Door")
        {
            interacting = true;
            colliding = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Interactable" || other.tag == "Door")
        {
            interacting = false;
            colliding = null;
        }
    }

}
