using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool open = true;
    public float DoorOpenAngle = 0f;
    public float DoorCloseAngle = 0f;
    public float smooth = 2f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, DoorOpenAngle, 0);
            transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation = Quaternion.Euler(0, DoorCloseAngle, 0);
            transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime);
        }
    }

    public void ChangeDoorState()
    {
        open = !open;
    }
}
