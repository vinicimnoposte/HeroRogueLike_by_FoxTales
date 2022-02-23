using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//C# me ensinou que eu ainda sou um magago
public class TriggerTest : MonoBehaviour
{
    public GameObject[] Presets;
    private System.Random RNumber = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(RNumber.Next(0, Presets.Length)); macaco
    }

    void OnCollisionEnter(Collision other){

        if(other.gameObject.CompareTag("Player")){
            int x;
            switch(x = RNumber.Next(0, Presets.Length)){
                case 0:
                    //God save you if you ever feel comfortable about that mess. Cuz your mind has probably lost its own sanity already.
                    Instantiate(Presets[x], new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 10f), Quaternion.identity);
                    Destroy(this.gameObject); //MWAHHAHAHAHAHAHAHAHAHAHHAHAHAHA SUCUMBA
                    //EU TO FICANDO INSANO KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK
                    break;
                case 1:
                    Instantiate(Presets[x], new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 10f), Quaternion.identity);
                    Destroy(this.gameObject);
                    break;
                case 2:
                    Instantiate(Presets[x], new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 10f), Quaternion.identity);
                    Destroy(this.gameObject);
                    break;
                
            }
            
            
        }
    }

}
