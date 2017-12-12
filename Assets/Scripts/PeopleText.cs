using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PeopleText
{
	public string name = "Inconnu";
	public string text = "Rien";
	public int age = 21;

	public string Name
	{
		get{ return name; }
		set{ name = value; }
	}

	public string Text
	{
		get{ return text; }
		set{ text = value; }
	}

	public int Age
	{
		get{ return age; }
		set{ age = value; }
	}

	public PeopleText CreateFromJSON(string jsonString)
	{
		return JsonUtility.FromJson<PeopleText>(jsonString);
	}

	public string SaveToString()
	{
		return JsonUtility.ToJson(this);
	}
}
