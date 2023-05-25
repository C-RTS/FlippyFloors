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

public class LevelCompleteTrig : MonoBehaviour
 {
	 	

	void Start () {
		this.transform.GetChild(0).gameObject.SetActive(false);
	}
	
	
	void Update () {
		
	}

/// <summary>
/// OnCollisionEnter is called when this collider/rigidbody has begun
/// touching another rigidbody/collider.
/// </summary>
/// <param name="other">The Collision data associated with this collision.</param>
void OnCollisionEnter(Collision other)
{
	if(other.gameObject.tag=="Player")
	{
		this.transform.GetChild(0).gameObject.SetActive(true);
		Invoke("LevelCom",1f);
		other.gameObject.tag="Untagged";
	}
}

void LevelCom()
{
	//if(PlayerPrefs.GetInt("levelNum")>=)
	PlayerPrefs.SetInt("levelNum",PlayerPrefs.GetInt("levelNum")+1);
	PlayerPrefs.SetInt("highLevel",PlayerPrefs.GetInt("levelNum"));
	if(PlayerPrefs.GetInt("levelNum")>=25)
	PlayerPrefs.SetInt("levelNum",0);
	GameManager.game_ref.levelComplete.SetActive(true);
	GameManager.game_ref.Ingame.SetActive(false);
	FindObjectOfType<AdManager>().ShowAd();
}
}
