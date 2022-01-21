using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegaGranada : MonoBehaviour
{
    public GameObject granadaMao, granadaCenario, granadaHUD;
    // Start is called before the first frame update
    void Start()
    {
        granadaMao.SetActive(false);
        granadaCenario.SetActive(true);
        granadaHUD.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            granadaMao.SetActive(true);
            granadaHUD.SetActive(true);
            granadaCenario.SetActive(false);
        }
    }
}
