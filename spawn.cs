using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class spawn : MonoBehaviour
{   
    public bool stopspawing = false;
    
    [SerializeField]
    GameObject enemyContainer;

    [SerializeField]
    GameObject enemyPrefab;

    public void OnPlayerDeath(){
        stopspawing = true;
    }
    IEnumerator SpawnRoutine(){
        while(true)
        {
            if(stopspawing == false){
                Vector3 pozisyon = new Vector3(Random.Range(-5.8f,5.8f),3.5f,0f);
                GameObject new_enemy = Instantiate(enemyPrefab,pozisyon,Quaternion.identity);
                new_enemy.transform.parent = enemyContainer.transform;
                yield return new WaitForSeconds(5.0f);
            }
            else{
                break;
            }
        }
    }


    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
