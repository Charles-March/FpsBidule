using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour {

    public float maxdistance = 200;
    public float timeW = 0.25f;
    public GameObject Text;
    private GameObject interactable = null;
    private float timer = 0;
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        if (Input.GetButtonDown("Use"))
        {

            if (interactable == null)
            {

            }
            else
            {
                if (interactable.tag == "Interactable")
                {
                    interactable.GetComponent<Interactable>().interact();
                }
                else if(interactable.tag == "Door")
                {

                    if (interactable.GetComponent<Door>().isLocked == false) interactable.GetComponent<Door>().Interact();
                    else
                    {
                        Text.GetComponent<Text>().text = "It's locked";
                        timer -= 2f;
                    }

               
                }
                
            }

        }


        timer += Time.deltaTime;
        if (timer > timeW)
        {
            if (transform.Find("interactCollider").GetComponent<Interact_trigger>().interacting == true)
            {
                interactable = transform.Find("interactCollider").GetComponent<Interact_trigger>().colliding;
                Text.GetComponent<Text>().text = interactable.GetComponent<Interactable>().InteractText;
            }
            else
            {
                Text.GetComponent<Text>().text = null;
                interactable = null;
            }

        }

    }
}
