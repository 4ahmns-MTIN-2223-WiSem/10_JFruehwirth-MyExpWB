using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public GameObject music;

    public void OnTriggerEnter(Collider other)
    {
        music.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        music.SetActive(false);
    }
}