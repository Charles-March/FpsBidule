using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {
    public bool state = false;
    public bool blocked = false;
    public bool SwitchTarget = false;
    public bool TwoStates = false;

    public GameObject On;
    public GameObject Off;

    public string InteractText = null;
    public GameObject interactwith = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void interact()
    {
        if (!blocked)
        {
            if (interactwith.tag == "Door")
            {
                interactwith.GetComponent<Door>().Interact();
                if (TwoStates)
                {
                    SwitchState();
                }

            }
        }
        else
        {

        }
    }

    private void SwitchState()
    {
        state = state == false;
        if (state)
        {
            On.SetActive(true);
            Off.SetActive(false);
        }
        else
        {
            On.SetActive(false);
            Off.SetActive(true);
        }
    }

}
