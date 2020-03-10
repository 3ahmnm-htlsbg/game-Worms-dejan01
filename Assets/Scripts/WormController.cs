using System.IO.IsolatedStorage;
using System.Net.Mime;
using System;
using System.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormController : MonoBehaviour
{

    //Worm
    public float thrust = 1.0f;
    public float negativeThrust = 1.0f;
    public Rigidbody rb;
    public Rigidbody b;
    public Transform prefab;
    public Transform spawnPosition;
    public int health = 10;
    public Rigidbody clone;
    public Text text1;

    private void Update()
    {
        //Worm
        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W wird aufgerufen");
            rb.AddForce(0, thrust, 0, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D wird aufgerufen");
            rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A wird aufgerufen");
            rb.AddForce(negativeThrust, 0, 0, ForceMode.Impulse);
        }
         if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S wird aufgerufen");
            rb.AddForce(0, negativeThrust, 0, ForceMode.Impulse);
        }
          if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Leertaste wird aufgerufen");
            clone = Instantiate(b, spawnPosition.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.left * -7);
        }

        if(health < 1){
            
        }

        UpdateLife();

    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    
     void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Bullet")
        {
           health = health -1;
           Debug.Log ("Kollision mit Bullet findet statt"); 
           Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Healthbox")
        {
           health = health +1;
           Debug.Log ("Kollision mit HealthBox findet statt"); 
        }
    }

    public void UpdateLife(){
        text1.text = health.ToString();
    }
    
}