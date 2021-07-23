using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPrefab;
    [SerializeField] private float ballShootForce;
    private Rigidbody ballRb;

    public Camera playerCam;
    [SerializeField] private float camOffset = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        ballRb = ballPrefab.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {        

    }

    private void LateUpdate()
    {
        transform.position = playerCam.transform.position;
        transform.rotation = playerCam.transform.rotation;
    }
}
