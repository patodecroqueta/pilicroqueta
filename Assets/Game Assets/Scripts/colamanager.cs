using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class colaManager : MonoBehaviour
{
    public GameObject imagencola;
    void OnTriggerEnter(Collider c){
        print("En el trigger");
        if (c.gameObject.name=="drink_002"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagencola.SetActive(true);
            //3. Añadimos al inventario
            //MAÑANA SERÁ OTRO DÍA
            GetComponent<Inventario>().AddItem(c.gameObject);
        }
    }
}
