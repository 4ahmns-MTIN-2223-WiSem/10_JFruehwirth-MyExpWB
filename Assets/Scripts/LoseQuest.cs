using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseQuest : MonoBehaviour
{
    public bool lost = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Failed");
        lost = true;
    }
}
