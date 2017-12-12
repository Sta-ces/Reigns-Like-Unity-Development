using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DataToJson : MonoBehaviour
{
	#region Public Members

	public AvatarInfo [] avatarsInfo;


	#endregion

	#region Public void

	#endregion

	#region System

		void Start ()
		{
			
			
		}
	
		void Update ()
		{
			
		}

	#endregion

	#region Tools Debug And Utility

	#endregion

	#region Private and Protected Members

	#endregion
}
[System.Serializable]
public class AvatarInfo{
public string _name="Default";
public int _age=15;

}