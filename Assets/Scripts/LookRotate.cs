using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookRotate : MonoBehaviour
{
    float xRotate = 0f;

    public float mouseSensi = 100f;

    public Transform playerBody;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensi * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensi * Time.deltaTime;

        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90, 90);

        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
