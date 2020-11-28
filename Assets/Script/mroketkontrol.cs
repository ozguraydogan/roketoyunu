using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


public class mroketkontrol : MonoBehaviour
{

    public Transform hedefGezegeni;
    public float yercekimigucu = 100.0f;
    public float yercekimiCapi = 10.0f;
    public Color Renk = Color.red;
    private Vector3 hedefYonu;
    public GameObject dunyadonus;
    public float dunyadonushizi;
    public Transform agirlikmerkezi;
    void Start()
    {
        
        Physics.gravity = Vector3.zero;

        GetComponent<Rigidbody>().centerOfMass = agirlikmerkezi.localPosition;
    }
    void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, hedefGezegeni.position);

        hedefYonu = hedefGezegeni.position - transform.position;
        hedefYonu = hedefYonu.normalized;

        if (distance < yercekimiCapi)
        {
            GetComponent<Rigidbody>().AddForce(hedefYonu * yercekimigucu * Time.deltaTime, ForceMode.Acceleration);
        }

        dunyadonus.transform.Rotate(0, dunyadonushizi, 0);
        
    }
    void OnGismosDraw()
    {
        Gizmos.color = Renk;
        Gizmos.DrawWireSphere(hedefGezegeni.position, yercekimiCapi);
    }
    private void OnBecameVisible()
    {
        GetComponent<RoketKontrol>().enabled = true;
    }


}
