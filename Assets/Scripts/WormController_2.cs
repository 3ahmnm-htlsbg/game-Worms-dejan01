using System.Net.Mime;
using System;
using System.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WormController_2 : MonoBehaviour
{
    public float thrust = 1.0f;
    public float negativeThrust = 1.0f;
    public Rigidbody rb;
    public Rigidbody b;
    public Transform prefab;
    public Transform spawnPosition;
    public int health = 10;
    public Rigidbody clone;
    public Text text;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up wird aufgerufen");
            rb.AddForce(0, thrust, 0, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("right wird aufgerufen");
            rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("left wird aufgerufen");
            rb.AddForce(negativeThrust, 0, 0, ForceMode.Impulse);
        }
         if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("down wird aufgerufen");
            rb.AddForce(0, negativeThrust, 0, ForceMode.Impulse);
        }
          if(Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("k wird aufgerufen");
            clone = Instantiate(b, spawnPosition.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.left * -7);
        }

        UpdateLife();
    }

    // Update is called once per frame
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
        }
        else {
            Debug.Log ("Kollision mit etwas anderem findet statt");
        }


        if (collision.gameObject.tag == "Healthbox")
        {
           health = health +1;
           Debug.Log ("Kollision mit HealthBox findet statt"); 
        }
        else {
            Debug.Log ("Kollision mit etwas anderem findet statt");
        }
    }

    public void UpdateLife(){
        text.text = health.ToString();

    }
    
}
