using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerMask_test : MonoBehaviour
{
	#region Public Members

		public LayerMask mask = -1;
		public PeopleText player;

		[Header("Debug Json")]
		public string debug;
		public string import;

	#endregion

	#region Public void

	#endregion

	#region System

		void Awake()
		{
			PeopleText _pt = player;
			_pt.Name = "Albert";
			_pt.Age = 83;
			string _text = _pt.SaveToString();
			PeopleText _json = _pt.CreateFromJSON(_text);
			Debug.Log(_text);
			Debug.Log(_json.name);
			debug = _text;
		}

	#endregion

	#region Tools Debug And Utility

	#endregion

	#region Private and Protected Members

		public void OnValidate(){

			// import  
			Debug.Log("Hello:"+import);
			import=null;

		}

	#endregion

}
