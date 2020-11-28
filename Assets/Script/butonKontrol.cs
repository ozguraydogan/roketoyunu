using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butonKontrol : MonoBehaviour
{
    public float guc;
    public float sagsolGüç;

    public bool gucB = false;
    public bool sag = false;
    public bool sol = false;
    public ParticleSystem gucPartical;
    public ParticleSystem sagPartical;
    public ParticleSystem solParticle;
    [SerializeField] private float fuel = 100f;
    [SerializeField] private Slider fuelSlider;
    private float currentFuel;
    [SerializeField]
    private float fuelBurnRate=20f;

    public GameObject gameOver;
    
    private void Awake()
    {
        Time.timeScale = 0.5f;

        currentFuel = fuel;
    }

    private void Update()
    {
        fuelSlider.value = currentFuel / fuel;
        if (currentFuel <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }

    private void FixedUpdate()
    {
        
        
        gucPartical.Stop();
        
        if (gucB) // neden sadece gucB yazdık gucB ne anlama gelmektedir.
        {
            GameObject.Find("roket").GetComponent<Rigidbody>().AddForce(transform.up * guc * Time.deltaTime, ForceMode.Acceleration);
            gucPartical.Play();
            currentFuel -= fuelBurnRate * Time.deltaTime;
        }

        if (sag)
        {
            GameObject.Find("roket").transform.Rotate(0, 0, -sagsolGüç * Time.deltaTime);
        }

        if (sol)
        {
            GameObject.Find("roket").transform.Rotate(0, 0, sagsolGüç * Time.deltaTime);
        }
    }

    public void gamePowerUp()
    {
        gucB = false;
        gameObject.GetComponent<AudioSource>().Stop();

    }
    public void gamePowerUDown()
    {
        gucB = true;
        gameObject.GetComponent<AudioSource>().Play();
    }

    public void gameRightUp()
    {
        sag = false;
        sagPartical.Stop();
    }
    public void gameRightDown()
    {
        sag = true;
        sagPartical.Play();
    }

    public void gameLeftUp()
    {
        sol = false;
        solParticle.Stop();
    }
    public void gameLeftDown()
    {
        sol = true;
        solParticle.Play();
    }
}
