using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlle : MonoBehaviour
{
    public float sensitivity = 100f;
    public float maxYAngle = 90f;

    private float rotationX = 0f; 
    public Transform playerTransform; // Объект игрока

    void Start()
    {
        
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime; ;

        // Поворачиваем игрока вокруг оси Y
        

        // Поворачиваем камеру вокруг своей локальной оси X
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -maxYAngle, maxYAngle);

        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

        playerTransform.Rotate(Vector3.up * mouseX);
    }
}
