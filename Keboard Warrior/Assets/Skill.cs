using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Skill : MonoBehaviour
{
    public delegate void SkillDelegate();

    public Dictionary<string, SkillDelegate> SkillDictionary = new Dictionary<string, SkillDelegate>();
    
    public Skill()
    {
        SkillDictionary.Add("icebreath", Icebreath);
        SkillDictionary.Add("firebreath", Firebreath);
        SkillDictionary.Add("punch", Punch);
    }

    public void Icebreath()
    {
        Debug.Log("Icebreath 발동!!");
    }

    public void Firebreath()
    {
        Debug.Log("Firebreath 발동!!");
    }

    public void Punch()
    {
        Debug.Log("Punch 발동!!");
    }

}
