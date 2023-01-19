using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopKnopf : MonoBehaviour
{
    public Behaviour behaviour;

    public void OnTriggerEnter(Collider other)
    {
        behaviour.animator.SetTrigger("Fin");
    }
}
