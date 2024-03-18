using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class sushiManager : MonoBehaviour
{
    public GameObject imagensushi;
    void OnTriggerEnter(Collider c){
        print("En el trigger");
        if (c.gameObject.name=="sushi_dish_001"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagensushi.SetActive(true);
            //3. Añadimos al inventario
            //MAÑANA SERÁ OTRO DÍA
            GetComponent<Inventario>().AddItem(c.gameObject);
        }
    }
}
