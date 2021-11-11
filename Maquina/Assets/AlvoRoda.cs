using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlvoRoda : MonoBehaviour
{
    [SerializeField] public Collider triger;

    [SerializeField]private Rigidbody rb;

    public bool roda = false;
    [SerializeField] private Vector3 torque;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(roda == true)
        {
            rb.useGravity = true;
            rb.angularVelocity =torque;
       
        }
    }
    private void OnTriggerEnter(Collider triger)
    {

        if (triger.gameObject.name == "Bola2")
        {
            rb.useGravity = true;
            roda = true;
        }
    }
}
