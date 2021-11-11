using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    [SerializeField] private HingeJoint _joint;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Bola1")
        {
            Destroy(_joint);
        }
    }
}
