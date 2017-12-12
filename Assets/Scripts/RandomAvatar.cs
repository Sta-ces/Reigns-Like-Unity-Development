using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomAvatar : MonoBehaviour
{
	#region Public Members

		public List<Texture> m_listAvatar;
		public RawImage m_photoAvatar;

	#endregion

	#region Public void

		public void GetRandomAvatar()
		{
			int numRand = m_listAvatar.Count+1;
			do{
				numRand = Random.Range(0,m_listAvatar.Count);
			}
			while(m_prevNumRand == numRand);

			m_prevNumRand = numRand;
			m_avatar = (Texture)m_listAvatar[numRand];
			m_photoAvatar.texture = m_avatar;
		}

	#endregion

	#region System

		private void Awake()
		{
			GetRandomAvatar();
		}

	#endregion

	#region Tools Debug And Utility

	#endregion

	#region Private and Protected Members

		private Texture m_avatar;
		private int m_prevNumRand;

	#endregion
}
