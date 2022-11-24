using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinQuest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("WIN");
    }
}
