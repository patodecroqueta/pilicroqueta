using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransporte : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if (c.gameObject.CompareTag("Player")){
            bool tieneOnigiri = c.gameObject.GetComponent<Inventario>().HasItem("Onigiri");
            if (tieneOnigiri){
                SceneManager.LoadScene("pilicroqueta3");
            }
        }
    }
}
