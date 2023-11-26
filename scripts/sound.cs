using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{

    [SerializeField] AudioClip Sound;
    private AudioSource src;

    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        src.PlayOneShot(Sound);
    }
}
