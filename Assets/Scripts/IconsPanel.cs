using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconsPanel : GameManager
{
	#region Public Members

	#endregion

	#region Public void

		public void ChangeFillIcon(float _percent, GameObject _imgIcon)
		{
			Image[] ii = _imgIcon.GetComponentsInChildren<Image>();
			foreach(Image _i in ii)
			{
				_i.fillAmount = _percent / 100f;
			}
		}

	#endregion

	#region System

	#endregion

	#region Tools Debug And Utility

	#endregion

	#region Private and Protected Members

	#endregion
}
