using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class galletaManager : MonoBehaviour
{
    public GameObject imagengalleta;
    void OnTriggerEnter(Collider c){
        print("En el trigger");
        if (c.gameObject.name=="Cookie"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagengalleta.SetActive(true);
            //3. Añadimos al inventario
            //MAÑANA SERÁ OTRO DÍA
            GetComponent<Inventario>().AddItem(c.gameObject);
        }
    }
}
