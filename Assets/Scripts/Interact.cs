using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public float interactDistance = 0f;
    public GameObject objectToInteractWith;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Console.WriteLine("HI");
            Ray ray = new Ray (transform.position, transform.forward);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, interactDistance))
            {
                if (hit.collider.CompareTag("Door"))
                {
                    Door doorComponent = hit.collider.GetComponent<Door>();
                    doorComponent.ChangeDoorState();
                }
            }
        }
    }
}
