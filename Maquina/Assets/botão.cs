using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botão : MonoBehaviour
{
    [SerializeField] private Rigidbody bola;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "dominosinho")
        {
            bola.useGravity = true;
        }
    }
}
