using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class martelo : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private Transform centerMass;
    public Vector3 torque;
    // Start is called before the first frame update
    private void Start()
    {
        centerMass = GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update()
    {

        rb.AddTorque(torque, ForceMode.Acceleration);
    }
}
