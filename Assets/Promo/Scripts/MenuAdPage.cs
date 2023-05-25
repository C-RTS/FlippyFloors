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
public class MenuAdPage : MonoBehaviour {
	public Image MenuAdImg;
	public GameObject CloseBtn;
	public static MenuAdPage instance;
	public bool  portraitloaded;
	public bool iconLoaded;
	public bool LandscapeLoaded;
	void Awake()
	{
		instance = this;
		gameObject.SetActive (false);
	//	CloseBtn.transform.localScale = Vector3.zero;
	}
	string url;
	public void Openad()
	{
		Application.OpenURL (url);
	}
	public void Close()
	{
		gameObject.SetActive (false);
	}

	public IEnumerator LoadImg()
	{
		int i = Random.Range (0,AdManager.instance.MgImgList.Count-1);
		MenuAdImg.sprite = AdManager.instance.MgImgList [i];
		url = AdManager.instance.MgLinkToList [i];
		yield return new WaitForSeconds (3);		
		gameObject.SetActive (true);

	}
	public IEnumerator Loadland()
	{
		int i = Random.Range (0,AdManager.instance.LandList.Count-1);
		MenuAdImg.sprite = AdManager.instance.LandList [i];
		url = AdManager.instance.LandToList [i];
		yield return new WaitForSeconds (3);		
		gameObject.SetActive (true);

	}

	public IEnumerator ShowAdInGamea()
	{
		int i = Random.Range (0,AdManager.instance.MgImgList.Count-1);
		MenuAdImg.sprite = AdManager.instance.MgImgList [i];
		url = AdManager.instance.MgLinkToList [i];
		yield return new WaitForSeconds (0.2f);		
		gameObject.SetActive (true);

	}

}
