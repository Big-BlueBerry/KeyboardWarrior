using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUI : MonoBehaviour
{
	public InputField inputStr;
	string input;
	Skill skill = new Skill();

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		input = inputStr.text;
		if(Input.GetKeyDown(KeyCode.Return))
		{
			inputStr.text = string.Empty;
			Debug.Log("Enter");
			if(IsSkill(input))
			{
				Debug.Log("Skill Active : " + input);
				skill.SkillDictionary[input]();
			}
		}
		
	}

	bool IsSkill(string input)
	{
		if (skill.SkillDictionary.ContainsKey(input)) return true;
		else return false;
	}
	
}
