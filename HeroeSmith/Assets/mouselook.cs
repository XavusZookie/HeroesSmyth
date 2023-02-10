using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public Transform playerbody;
    public float mousesensativity = 100f;
    public float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousesensativity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesensativity * Time.deltaTime;

        playerbody.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerbody.Rotate(Vector3.up * mouseX);
    }

    public void mouseunlocker()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void mouselocker()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
