using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerMask_test : MonoBehaviour
{
	#region Public Members

		public LayerMask mask = -1;

	#endregion

	#region Public void

	#endregion

	#region System

		void Awake()
		{
			/*for(int i = 0; i < 10; i++)
			{
				Debug.Log(LayerMask.LayerToName(i));
			}*/

			PeopleText _pt = new PeopleText();
			_pt.Name = "Albert";
			_pt.Age = 83;
			string _text = _pt.SaveToString();
			Debug.Log(_text);
			Debug.Log(_pt.CreateFromJSON(_text));
		}

	#endregion

	#region Tools Debug And Utility

	#endregion

	#region Private and Protected Members

	#endregion
}
