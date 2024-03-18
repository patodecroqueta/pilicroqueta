using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TartaManager : MonoBehaviour
{
    public GameObject imagenTarta;
    void OnTriggerEnter(Collider c){
        if (c.gameObject.name=="Cake"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagenTarta.SetActive(true);
            //3. Añadimos al inventario
            GetComponent<Inventario>().AddItem(c.gameObject);//Añadir la llave al inventario
        }
    }
}
