using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Skill : MonoBehaviour
{
    public delegate void SkillDelegate();

    Dictionary<string, SkillDelegate> SkillDictionary = new Dictionary<string, SkillDelegate>();

    Skill()
    {
        SkillDictionary.Add("icebreath", Icebreath);
        SkillDictionary.Add("firebreath", Firebreath);
        SkillDictionary.Add("punch", Punch);
    }

    public void Icebreath()
    {

    }

    public void Firebreath()
    {

    }

    public void Punch()
    {

    }

}
