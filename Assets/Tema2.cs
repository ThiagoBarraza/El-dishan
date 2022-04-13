using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema2 : MonoBehaviour
{

    public string nombre;
    public int año;
    public string especialidad;
    //T para TIC, D para Diseño, G para Gestión, M para Medios y H para Humanidades
    
    // Start is called before the first frame update
    void Start()
    {
        bool AAA = false;
        
        if(año < 1 || año > 5)
        {

            switch (especialidad)
            {
                case "T":
                    AAA = true;
                    break;
                case "D":
                    AAA = true;
                    break;
                case "G":
                    AAA = true;
                    break;
                case "M":
                    AAA = true;
                    break;
                case "H":
                    AAA = true;
                    break;
                default:
                    AAA = false;
                    break;
                

            }

            if (año < 3)
            {
                Debug.Log("Error. Aún estás en el ciclo básico");
            }
            else
            {
                Debug.Log("Muchas Gracias " + nombre + "!");
            }


            
                
        }
        
        else
        {
            if(año == 0)
            {
                Debug.Log("el año esta vacio");
            }
            else
            {
                Debug.Log("Fuera de rango");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
