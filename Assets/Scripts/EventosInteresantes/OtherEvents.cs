using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OtherEvents : MonoBehaviour
{
    //UnityEvent: Es un sistema de eventos integrado en Unity que permite a los desarrolladores crear eventos personalizados y asignarles métodos para que se ejecuten cuando se disparan esos eventos.
    [SerializeField] private UnityEvent misEventos; // Declaración de un UnityEvent serializable en el inspector.

    //Evento personalizado
    [SerializeField] private event System.Action eventoPersonalizado; // Declaración de un evento personalizado usando System.Action.

    // Start is called before the first frame update
    void Start()
    {
        if (misEventos == null) return;
        misEventos.AddListener(OnDisable); // Ejemplo de agregar un listener al evento desde el mismo script.
        misEventos.AddListener(() => Debug.Log("mini funcion llamada")); // Agregar un listener anónimo.
        misEventos.AddListener(() => {
            Debug.Log("Funcion llamada desde evento");
            OtraAccion(100);
        });// Agregar un listener anónimo con múltiples líneas de código.


        misEventos.Invoke(); //Invoke se usar para disparar el evento y llamar a todos los métodos asignados a él.

        eventoPersonalizado += MetodoPersonalizado; // Suscripción al evento personalizado.
        eventoPersonalizado.Invoke(); // Disparo del evento personalizado.
    }

    //---------------------- UnityEvent ---------------------
    private void OnDisable() {
        if (misEventos == null) return;
        misEventos.RemoveAllListeners();
        Debug.Log("OnDisable invoked and all listeners removed.");
    }
    private void OtraAccion(int value) {
        Debug.Log($"Otra acción ejecutada desde el evento. {value}");
    }

    //---------------------- Event Personalizado ---------------------
    private void MetodoPersonalizado() {
        if(eventoPersonalizado == null) return;
        eventoPersonalizado -= MetodoPersonalizado; // Desuscripción del evento personalizado.
        Debug.Log("Evento personalizado invocado.");
    }

    //Resumen: -> UnityEvent es una forma fácil y visual de manejar eventos en Unity, mientras que los eventos personalizados ofrecen más flexibilidad y control a nivel de código.
    //Consumos: -> UnityEvent tiene un mayor consumo, mientras que, los eventos personalizados son más eficientes en términos de rendimiento.
}
