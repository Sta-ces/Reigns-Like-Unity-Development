using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconsPanel : MonoBehaviour
{
	#region Public Members

		[Range(0f,100f)]
		public float m_percentDebut = 50f;

	#endregion

	#region Public void

		public void ChangeFillIcon(float _percent, GameObject _imgIcon)
		{
			_imgIcon.GetComponent<Image>().fillAmount = _percent / 100f;
		}

	#endregion

	#region System

		void Awake()
		{
			InitLevelIcons();
		}

	#endregion

	#region Tools Debug And Utility

		private void InitLevelIcons()
		{
			GameObject imgIcon = transform.GetChild(0).gameObject;
			ChangeFillIcon(m_percentDebut, imgIcon);
		}

	#endregion

	#region Private and Protected Members

		// private GameObject[] m_icons;

	#endregion
}
