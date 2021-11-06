using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class martelo : MonoBehaviour
{
    [SerializeField] public Rigidbody rb;
    private Transform centerMass;
    public Vector3 torque;
    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.Find("Cylinder").GetComponent<Rigidbody>();
        centerMass = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       
        rb.AddTorque(torque, ForceMode.Acceleration);
    }
}
