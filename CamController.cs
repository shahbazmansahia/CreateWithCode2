using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    private float horizontalInput;
    public float angularInput;

    private float rotationSpeed = 50.00f;
    private float angularSpeed = 500.00f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        angularInput = Input.GetAxis("Mouse ScrollWheel");

        transform.Rotate(Vector3.down, horizontalInput * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward, angularSpeed * angularInput * Time.deltaTime);
    }
}
