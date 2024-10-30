using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class enemysc : MonoBehaviour
{
    float speed = 3.0f;
    float randomX;
    int puan = 0;
    string yazdır;
    spawn spawncss;
    void Start()
    {
        spawncss = GameObject.Find("deneme").GetComponent<spawn>();
    
    }

    // Update is called once per frame
    void Update()
    {
        if(spawncss.stopspawing == false){
            transform.Translate(Vector3.down*speed*Time.deltaTime);
            if(transform.position.y<-3.5){
                randomX = Random.Range(-5.5f,5.5f);
                transform.position = new Vector3(randomX,3.5f,5);
    }}
        else{
            Destroy(this.gameObject);
        }
    }
    
    
    
    void OnTriggerEnter(Collider other){
            if(other.transform.name == "Capsule(Clone)"){
                randomX = Random.Range(-5.5f,5.5f);
                transform.position = new Vector3(randomX,3.5f,5);
            
        }
    }
    
}

