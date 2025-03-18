using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prog8 : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Move()
    {
        animator.SetTrigger("move");
        audioSource.Play();
    }
}
