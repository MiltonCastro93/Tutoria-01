using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class CreateEfecto : MonoBehaviour
{
    public DataHabilidades GetSkill;
    public ParticleSystem effectAsset;

    public MoveSphere moveSphere; //referencia al script MoveSphere, para usar sus delegados, Action y Func

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            ejecte("");
        }
        if(effectAsset != null) {
            if (!effectAsset.isPlaying) {
                Destroy(effectAsset.gameObject);
            }

        }
        //moveSphere.GetComponent<MoveSphere>().myFunc += ejecute;
        //moveSphere.GetComponent<MoveSphere>().myFunc.Invoke("10"); //myFunc es invocado 1° desde el start de MoveSphere, luego desde aqui cambiando su valor.
    }

    void ejecte(string codigo)
    {
        Debug.Log("Name skill: " + GetSkill.name);

        if (effectAsset == null) {
            effectAsset = Instantiate(GetSkill.mivfx(),transform);
            effectAsset.transform.localPosition = GetSkill.extra();
        }

    }

    int ejecute(string codigo)
    {
        Debug.Log("Ejecute desde CreateEfecto con codigo: " + codigo);
        return 0;
    }

}
