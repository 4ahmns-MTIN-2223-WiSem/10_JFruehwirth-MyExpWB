using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseQuest : MonoBehaviour
{
    public bool lost = false;
    public Behaviour behaviour;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Failed" + other.name);
        lost = true;
        behaviour.Zurueck();
        behaviour.count = 0;
    }
}
