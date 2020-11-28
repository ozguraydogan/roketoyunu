using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disduvar : MonoBehaviour
{
    public GameObject tekrarOyna;
    private void OnTriggerExit(Collider other)
    {
        GameObject.Find("roket").SetActive(false);
        tekrarOyna.SetActive(true);
    }
}
