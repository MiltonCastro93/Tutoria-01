using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputManagerEntry;

public class ManagerTurn : MonoBehaviour
{
    [SerializeField] private GameObject[] Enemigos;

    void Update() {
        if (Input.GetKeyDown(KeyCode.T)) {
            Debug.Log("Iniciando turno de enemigos...");

            for (int i = 0; i < Enemigos.Length; i++) {
                ActivarComportamiento(Enemigos[i].GetComponent<EnemyHumanoide>());
                OnAtaqueEspecial(Enemigos[i].GetComponent<EnemyLagartos>());

                // Alternativamente, usando el enfoque comentado abajo: Pasara null si no es del tipo esperado
                //EnemyHumanoide enemigo = Enemigos[i].GetComponent<EnemyHumanoide>();

                //if (enemigo != null) {
                //    Debug.Log($"Es un enemigo humanoide: {enemigo.name}");
                //    ActivarComportamiento(enemigo);
                //} else {
                //    Debug.LogWarning($"{Enemigos[i].name} no tiene componente EnemyHumanoide");
                //}

                EnemyHumanoide enemigo = Enemigos[i].GetComponent<EnemyHumanoide>(); //Puedo usarlos en todos, pero tiene demasiado consumo en memoria

                if (enemigo != null && enemigo.GetType() == typeof(EnemyHumanoide)) 
                {
                    enemigo.HumanoAtaque();
                }

                if (enemigo is EnemyHumanoide)//mas limpio en codigo y rapido, comparando el GetType
                {
                    enemigo.HumanoAtaque();
                }

            }

        }

    }

    private void ActivarComportamiento<T>(T target) where T : EnemyHumanoide {
        if (target == null) return; // Validacion para evitar errores si el tipo no coincide

        target.HumanoAtaque();
        Debug.Log($"Turno de enemigo activado {target.name}.");
    }

    private void OnAtaqueEspecial<T>(T target) where T : EnemyLagartos {
        if(target == null) return;
        target.BesodeLagarto(Random.Range(2,100));
    }


}
//Resumen: -> Cuando se usa funciones genéricas con restricciones de tipo (where T : EnemyHumanoide), Unity o C# no filtra automáticamente los tipos incorrectos.
//Vos le estás diciendo: “Voy a intentar pasar cualquier cosa, pero si no es del tipo que espero, va a devolver null.”