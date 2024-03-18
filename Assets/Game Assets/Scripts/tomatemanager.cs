using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class tomateManager : MonoBehaviour
{
    public GameObject imagentomate;
    void OnTriggerEnter(Collider c){
        print("En el trigger");
        if (c.gameObject.name=="tomato_001"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagentomate.SetActive(true);
            //3. Añadimos al inventario
            //MAÑANA SERÁ OTRO DÍA
            GetComponent<Inventario>().AddItem(c.gameObject);
        }
    }
}
