using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class inis : MonoBehaviour
{
    [SerializeField] private GameObject kazandıUı;
    [SerializeField] private GameObject marsOrta;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "altCollider")
        {
            Time.timeScale = 0.0f;
            kazandıUı.SetActive(true);
        }
    }

    public void yenidenBaslat()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene("sahne");
       
    }
}
