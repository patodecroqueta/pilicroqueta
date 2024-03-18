using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnigiriManager : MonoBehaviour
{
    public GameObject imagenOnigiri;
    void OnTriggerEnter(Collider c){
        if (c.gameObject.name=="Onigiri"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagenOnigiri.SetActive(true);
            //3. Añadimos al inventario
            GetComponent<Inventario>().AddItem(c.gameObject);//Añadir la llave al inventario
        }
    }
}
