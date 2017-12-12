using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerMask_test : MonoBehaviour
{
	#region Public Members

		public LayerMask m_mask = -1;
		public PeopleText m_peopleInfo;

		[Header("Debug Json")]
		public string m_debug;
		public string m_import;

	#endregion

	#region Public void

	#endregion

	#region System

		void Awake()
		{
		}

	#endregion

	#region Tools Debug And Utility

	#endregion

	#region Private and Protected Members

		public void OnValidate(){

			string text = m_peopleInfo.SaveToString();
			PeopleText json = m_peopleInfo.CreateFromJSON(text);
			m_debug = text;

			// import
			m_import = m_debug;
			Debug.Log("Hello: "+m_import);
			m_import = null;

		}

	#endregion

}
