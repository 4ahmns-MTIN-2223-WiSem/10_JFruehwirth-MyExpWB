using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartKnopf : MonoBehaviour
{
    public Behaviour behaviour;

    public void OnTriggerEnter(Collider other)
    {
        behaviour.animator.enabled = true;
        behaviour.a.enabled = true;
    }
}
