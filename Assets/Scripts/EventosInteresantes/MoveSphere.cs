using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    //----Delegados
    public delegate void fullJob(string pass); //definicion del delegado, pasa un string, y puede tener varios tipos de returno void, int, float, etc
    public fullJob Mydelegado = null;          //instancia del delegado si o si.

    //----Action
                                           //No necesita definicion previa como los delegados.
    public Action<string> myAction = null; //asignacion del metodo al Action que envia un string, su unico returno es void.


    //----Func
                                            //No necesita definicion previa como los delegados.
    public Func<string, int> myFunc = null; //asignacion del metodo al Func que envia un string y retorna un int.


    void Start() {
        Mydelegado += saludo; //asignacion del metodo al delegado, no necesita parentesis.
        Mydelegado?.Invoke("hola");

        myAction += saludo; //asignacion del metodo al Action
        myAction?.Invoke("hello");

        myFunc += despedida; //asignacion del metodo al Func
        Debug.Log("El valor retornado es: " + myFunc?.Invoke("hi")); //invocacion del metodo del Func
    }

    public void saludo(string messege) {
        Debug.Log(messege + " desde MoveSphere");
        if (Mydelegado == null || myAction == null) return; //verificacion para evitar errores si el delegado o Action no tienen metodos asignados.

        Mydelegado -= saludo; //remover el metodo del delegado
        myAction -= saludo; //remover el metodo del Action
    }

    public int despedida(string messege) {
        Debug.Log(messege + " desde MoveSphere");
        return 0;
    }

    //RESUMEN: -> Entonces los tres aceptan parámetros, pero "delegate" como el "Func" pueden tener algun tipo de return, mientras que, el "Action" es del tipo void.
    //-> Los "Action" y "Func" no necesitan una definición previa como los delegados.
    //-> Los "Action" y "Func" tiene un maximo de parametros, 16, mientras que los delegados no tienen limite.
    //-> Los "Func" el ultimo parametro es el tipo de returno, mientras que los otros son los parametros de entrada.

}
