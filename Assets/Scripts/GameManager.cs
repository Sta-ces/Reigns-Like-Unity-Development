using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	#region Public Members

		public PeopleText[] m_peopleText;

		[Range(0f,100f)]
		public float m_percentDebut = 50f;
		public GameObject m_iconPanel;

		public static RawImage m_photoAvatar;
		public static Object[] m_listAvatar;
		public static int m_prevNumRand;

	#endregion

	#region Public void

	#endregion

	#region System

		void Reset()
		{
			m_listAvatar = m_randomAvatar.GetAllAvatar("Avatar");
		}

		void Awake()
		{
			m_iconsPanel = new IconsPanel();
			m_iconsPanel.ChangeFillIcon(m_percentDebut,m_iconPanel);

			m_randomAvatar = new RandomAvatar();
			// m_listAvatar = m_randomAvatar.GetAllAvatar("Avatar");
			/*Object[] rsc = Resources.LoadAll("Avatar");
			Debug.Log(rsc[0].name);*/
			m_randomAvatar.GetRandomAvatar("Avatar");
		}

		void Update()
		{
		}

	#endregion

	#region Tools Debug And Utility

	#endregion

	#region Private and Protected Members

		private IconsPanel m_iconsPanel;
		private RandomAvatar m_randomAvatar;

	#endregion
}
