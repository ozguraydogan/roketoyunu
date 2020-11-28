using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ikincigezegengecis : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        GameObject.Find("roket").GetComponent<RoketKontrol>().enabled = false;
        GameObject.Find("roket").GetComponent<mroketkontrol>().enabled = true;
    }
}
