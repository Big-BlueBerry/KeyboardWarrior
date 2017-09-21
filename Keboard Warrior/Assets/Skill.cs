using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    delegate void SkillDelegate(int n);

    List<SkillDelegate> SkillList = new List<SkillDelegate> { };

    Dictionary<string, SkillDelegate> SkillDictionary = new Dictionary<string, SkillDelegate>();
    SkillDictionary.Add("firebress", Skill.Firebress);
    
    SkillDelegate input = SkillDictionary["icebress"];

    public void Icebress(int n)
    {

    }
    public void Firebress(int n)
    {

    }
}
