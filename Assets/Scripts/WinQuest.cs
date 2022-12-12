using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinQuest : MonoBehaviour
{
    public bool won = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("WIN");
        won = true;
    }
}
