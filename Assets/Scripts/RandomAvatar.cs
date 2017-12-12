using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomAvatar : GameManager
{
	#region Public Members

		// public List<Texture> m_listAvatar;
		// public RawImage m_photoAvatar;

	#endregion

	#region Public void

		/*private RandomAvatar _listAvatar;

		public RandomAvatar ListAvatar
		{
			get{ return m_listAvatar; }
			private set
			{
				m_listAvatar = Resources.LoadAll(value) as List<Texture>;
			}
		}*/
		public Object[] GetAllAvatar(string _path)
		{
			return Resources.LoadAll(_path, typeof(Texture));
		}

		public void GetRandomAvatar(string _path)
		{
			m_listAvatar = (m_listAvatar==null)?GetAllAvatar(_path):m_listAvatar;
			int numRand = m_listAvatar.Length;
			do{
				numRand = Random.Range(0,m_listAvatar.Length);
			}
			while(m_prevNumRand == numRand);

			m_prevNumRand = numRand;
			m_photoAvatar.texture = (Texture)m_listAvatar[numRand];
		}

	#endregion

	#region System

	#endregion

	#region Tools Debug And Utility

	#endregion

	#region Private and Protected Members

	#endregion
}
