using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

[System.Serializable]
public struct valueSkill
{
    public Vector3 position;
    public int Danio;
    public string NameSkill;
    public ParticleSystem VFX;
}

[CreateAssetMenu(fileName = "NewSkill",menuName = "MakeSkill/Skill")]
public class DataHabilidades : ScriptableObject
{
    //public Vector3 position;
    //public int Danio;
    //public string NameSkill;
    //public ParticleSystem VFX;

    [SerializeField] private valueSkill skill;  //> sin esta varible no funciona el struct, ya que debe estar complendida por la herencia de ScriptableObject o MonoBehaviour

    public Vector3 extra()
    {
        //VFX.transform.position = position; //>sin usar struct
        return skill.VFX.transform.position = skill.position;
    }

    public ParticleSystem mivfx() => skill.VFX; // es lo mismo que public ParticleSystem mivfx() { return skill.VFX; }
}
