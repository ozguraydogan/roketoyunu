using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerakontroller : MonoBehaviour
{
    private Vector3 mesafe;
    public GameObject Rocket;

    void Start()
    {
        mesafe = transform.position - Rocket.transform.position;
    }
    void Update()
    {
        transform.position = Rocket.transform.position + mesafe;
    }
}