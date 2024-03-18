using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CafeManager : MonoBehaviour
{
    public GameObject imagenCafe;
    void OnTriggerEnter(Collider c){
        if (c.gameObject.name=="coffee_001"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagenCafe.SetActive(true);
            //3. Añadimos al inventario
            GetComponent<Inventario>().AddItem(c.gameObject);//Añadir la llave al inventario
        }
    }
}
