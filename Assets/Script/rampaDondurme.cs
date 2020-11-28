using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rampaDondurme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int rastgele= Random.Range(-60, 60);
        GameObject.Find("marsorta").transform.Rotate(0,0,rastgele);
    }
}
