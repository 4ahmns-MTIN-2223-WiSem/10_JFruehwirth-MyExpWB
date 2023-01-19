using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracteKnopf : MonoBehaviour
{
    public Behaviour behaviour;

    public void OnTriggerEnter(Collider other)
    {
        behaviour.a.SetTrigger("pressed");
    }
}
