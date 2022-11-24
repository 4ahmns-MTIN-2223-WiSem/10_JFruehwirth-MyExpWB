using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseQuest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Failed");
    }
}
