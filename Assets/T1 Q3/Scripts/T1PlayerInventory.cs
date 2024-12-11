using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define los tipos de ítems en un enum para evitar errores de escritura y facilitar el uso


public class T1PlayerInventory : MonoBehaviour
{
    //---------
    //Variables
    //---------

    // Definir un delegado para el evento de cambio de inventario

    // Crear evento que se activa cada vez que el inventario cambia

    //Elemento seleccionado por el jugador que se intenta agregar o usar


    //Diccionario que actúa como inventario del jugador (clave: tipo de objeto, valor: cantidad)

    //-------------------------------------------
    //Método para agregar un objeto al inventario
    //-------------------------------------------


    //Si el objeto ya está en el inventario, incrementa la cantidad


    //Si el objeto no está en el inventario, se agrega con cantidad inicial 1


    // Activar el evento para notificar que el inventario ha cambiado



    //-----------------------------------------
    //Método para usar un objeto del inventario
    //-----------------------------------------


    //Comprueba si el objeto existe en el inventario y si el jugador tiene más de 0 unidades, se usa el objeto



    // Activar el evento para notificar que el inventario ha cambiado


    //------
    //Update
    //------


    //Si el jugador presiona el botón izquierdo del mouse, agrega el objeto al inventario



    //Si el jugador presiona el botón derecho del mouse, usa el objeto del inventario



}