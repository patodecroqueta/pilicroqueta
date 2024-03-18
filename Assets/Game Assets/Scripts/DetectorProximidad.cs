using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorProximidad : MonoBehaviour
{
    public GameObject gameObject;

    public void OnTriggerEnter(){
        gameObject.SetActive(true);
    }
}
