using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//El nombre de la clase debe ser igual al nombre del archivo.
//El objeto hereda de MonoBehaviour, lo que significa que es un componente de Unity.
public class MoveObject : MonoBehaviour
{
    float muevete, y, z;
    public Vector3 speed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update() //120 fps, se ejecuta 120 veces por segundo.
    {
        //En una computadora potente, 0.0083333333333333. Se suma 120 veces por segundo.
        //En una computadora lenta, 0.05. Se suma 20 veces por segundo.
        //En una computadora potente se suma un numero muy pequeño por iteracion y en una lenta un numero mas grande.
        //Al fin del dia, se llega al mismo numero por las repeticiones.
        //muevete += Time.deltaTime;
        //POdemos agregar una distancia para que se muevan la misma distancia en cualquier computadora.
        muevete += speed.x * Time.deltaTime;
        y += speed.y * Time.deltaTime;
        z += speed.z * Time.deltaTime;
        transform.position = new Vector3(muevete, y, z);
    }
}

// SI son 60 cuadron por segundo, cada cuadro dura 0.0166666666666667 segundos
// SI son 30 cuadron por segundo, cada cuadro dura 0.0333333333333333 segundos
// SI son 15 cuadron por segundo, cada cuadro dura 0.0666666666666667 segundos
//Si son 24 cuadros por segundo, cada cuadro dura 0.0416666666666667 segundos    1/24 = 0.0416666666666667
//Como le hacen los juegos para que una bala se vea y atue igual en una compu que da 10 frames por segundo que una que da 60, usan el delta time, lo que calculamos ahorita.
//120 fps = 0.0083333333333333, 20 fps = 0.05. 