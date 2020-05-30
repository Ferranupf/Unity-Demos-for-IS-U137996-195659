﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float runSpeed;
    private ObstacleSpawner obstacleSpawner;

    public float dropDestroyDelay ; 
    private Collider myCollider; 
    private Rigidbody myRigidbody;
    
    // public float heartOffset; 
    // public GameObject heartPrefab; 

    public void SetSpawner(ObstacleSpawner spawner)
    {
        obstacleSpawner = spawner;
    }


    void Start()
    {
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * runSpeed * Time.deltaTime);
    }

    private void TriggerDestroy(){
        //obstacleSpawner.RemoveObstacleFromList (gameObject);
        //myRigidbody.isKinematic = false; 
        //myCollider.isTrigger = false; 
        Destroy(gameObject, dropDestroyDelay); 
        GameStateManager.Instance.ObstacleAvoided();
    }

    private void HitByBody(){
        //obstacleSpawner.RemoveObstacleFromList (gameObject);
        runSpeed = 0; 
        Destroy(gameObject);
        GameStateManager.Instance.HitByObstacle();
    }

    private void OnTriggerEnter (Collider other) 
    {
        
        if (other.CompareTag("Body")) 
        {
            HitByBody(); 
            //END OF GAME
        }
        
        if(other.CompareTag("Trigger") ){
            TriggerDestroy(); 
        }
    }

}