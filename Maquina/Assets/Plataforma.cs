using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{

    public Rigidbody rbRampa;
    public Vector3 cMassRampa;
    // Start is called before the first frame update
    void Start()
    {
        rbRampa = GameObject.Find("Rampa").GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        rbRampa.centerOfMass = cMassRampa; 
    }
}
