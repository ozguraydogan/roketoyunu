using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roketus : MonoBehaviour
{
    public GameObject tekrarOyna;
    public GameObject roket;
    public GameObject patlamaEfekt;
    void OnCollisionEnter(Collision roket)
    {
        GameObject.Find("roket").SetActive(false);
        //Destroy(roket.gameObject);   // Roketi yokedince kamera hatası alıyoruz bunun için roketi pasif yaptık.
        Instantiate(patlamaEfekt, roket.transform.position, roket.gameObject.transform.rotation);
        GameObject.Find("patlamaSes").GetComponent<AudioSource>().Play();
        //SceneManager.LoadScene("sahne");  // Güzel olmadı.
        tekrarOyna.SetActive(true);
    }
}
