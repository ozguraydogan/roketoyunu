using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatlamaEfekti : MonoBehaviour
{
        
    public ParticleSystem patlamaEfekt;
    private void OnCollisionEnter(Collision other)
    {
        ParticleSystem boom = patlamaEfekt.GetComponent<ParticleSystem>();
        boom.Play();
    }
}
