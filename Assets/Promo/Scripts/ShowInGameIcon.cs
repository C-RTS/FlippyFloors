/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件由会员免费分享，如果商用，请务必联系原著购买授权！

daily assets update for try.

U should buy a license from author if u use it in your project!
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowInGameIcon : MonoBehaviour {
	
	Sprite loadedsprite;
	string loadedlink;
	Image thisimage;
	void Awake(){
		thisimage = GetComponent<Image> ();
	}
	void OnEnable(){
		if (AdManager.instance && AdManager.instance.IconLoaded) {

			int i = Random.Range(0,AdManager.instance.Iconlist.Count-1);
			loadedsprite = AdManager.instance.Iconlist[i];
			loadedlink = AdManager.instance.IconToList[i];
			thisimage.sprite = loadedsprite;

			Debug.Log (loadedlink);
		} else {
			gameObject.SetActive (false);
		}

		IconAnimation ();
	}
	public 	void OnButtonClick(){
		Application.OpenURL (loadedlink);
	}

	void IconAnimation()
	{
		iTween.ScaleTo (gameObject, iTween.Hash ("x", 1.2f, "y", 1.2f, "z", 1.3f, "easeType", iTween.EaseType.linear, "time", 1f,"loopType",iTween.LoopType.pingPong));
	}
}
