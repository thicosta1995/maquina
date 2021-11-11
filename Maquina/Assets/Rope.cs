using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    [SerializeField] private HingeJoint _joint;
    [SerializeField] private AlvoRoda alvo;


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Bola2")
        {
            Destroy(_joint);
            alvo.roda = true;
        }
    }
}
