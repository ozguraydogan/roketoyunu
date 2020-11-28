using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitti : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision nesne)
    {
        
        if (nesne.gameObject.tag== "Finish")
        {
            Debug.Log("Ozgurrr");
        }
    }
}
