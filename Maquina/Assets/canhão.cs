using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class canhão : MonoBehaviour
{
    public GameObject[] bolas;
    public Rigidbody[] rb;
    public Vector3 impulso;
    // Start is called before the first frame update
    private void Awake()
    {
    }
    void Start()
    {

        bolas = GameObject.FindGameObjectsWithTag("Bola");

        rb = new Rigidbody[bolas.Length];

        for (int i =0; i<bolas.Length;++i)
        {
            
            rb[i] = bolas[i].GetComponent<Rigidbody>();
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bola")
        {

            
            rb[1].AddForce(impulso);
            Debug.Log("entrou");
        }
        if (other.gameObject.name == "Bola1")
        {


            rb[0].AddForce(impulso);
            Debug.Log("entrou");
        }
    }
}
