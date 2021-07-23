using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPrefab;
    [SerializeField] private float ballShootForce;
    private Rigidbody ballRb;

    public Camera playerCam;
    // Start is called before the first frame update
    void Start()
    {
        ballRb = ballPrefab.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
