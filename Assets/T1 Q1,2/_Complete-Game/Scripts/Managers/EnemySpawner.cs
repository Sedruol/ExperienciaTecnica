using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompleteProject
{
    public class EnemySpawner : MonoBehaviour
    {
        //---------
        //Variables
        //---------
        // Referencia al Script PlayerHealth

        // Los prefabs de los enemigos que se usarán en el spawn

        // Los tiempos que habrá entre cada spawn de cada enemigo

        // Los transforms de los puntos de spawn de cada enemigo

        //-----
        //Start
        //-----

        // Iniciar la corrutina para spawnear enemigos con el prefab, tiempo de spawn y punto de spawn correspondientes


        //-----------
        //Ienumerator
        //-----------


        // Esperar el tiempo definido antes de spawnear el enemigo

        // Verificar si la salud del jugador es menor o igual a 0

        // Si el jugador ha sido derrotado, salir de la función y no spawnear más enemigos

        // Instanciar el enemigo en la posición y rotación del punto de spawn

        // Volver a llamar a la corrutina para spawnear otro enemigo después del mismo tiempo

    }
}