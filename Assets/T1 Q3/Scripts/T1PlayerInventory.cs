using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define los tipos de �tems en un enum para evitar errores de escritura y facilitar el uso


public class T1PlayerInventory : MonoBehaviour
{
    //---------
    //Variables
    //---------

    // Definir un delegado para el evento de cambio de inventario

    // Crear evento que se activa cada vez que el inventario cambia

    //Elemento seleccionado por el jugador que se intenta agregar o usar


    //Diccionario que act�a como inventario del jugador (clave: tipo de objeto, valor: cantidad)

    //-------------------------------------------
    //M�todo para agregar un objeto al inventario
    //-------------------------------------------


    //Si el objeto ya est� en el inventario, incrementa la cantidad


    //Si el objeto no est� en el inventario, se agrega con cantidad inicial 1


    // Activar el evento para notificar que el inventario ha cambiado



    //-----------------------------------------
    //M�todo para usar un objeto del inventario
    //-----------------------------------------


    //Comprueba si el objeto existe en el inventario y si el jugador tiene m�s de 0 unidades, se usa el objeto



    // Activar el evento para notificar que el inventario ha cambiado


    //------
    //Update
    //------


    //Si el jugador presiona el bot�n izquierdo del mouse, agrega el objeto al inventario



    //Si el jugador presiona el bot�n derecho del mouse, usa el objeto del inventario



}