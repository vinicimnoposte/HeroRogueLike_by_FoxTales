using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float zped = 10f;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            Player.transform.Translate(new Vector3(0f,0f,zped * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.A)){
            Player.transform.Translate(new Vector3(-zped * Time.deltaTime,0f,0f));
        }
        if(Input.GetKey(KeyCode.D)){
            Player.transform.Translate(new Vector3(zped * Time.deltaTime,0f,0f));
        }
        if(Input.GetKey(KeyCode.S)){
            Player.transform.Translate(new Vector3(0f,0f,-zped * Time.deltaTime));
        }
    }
}
