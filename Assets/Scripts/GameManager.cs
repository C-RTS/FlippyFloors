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

public class GameManager : MonoBehaviour 
{
	public static GameManager game_ref;
	public GameObject[] levels;
	public GameObject bg,levelComplete,Ingame,player;
	public Material[] materials,ballMat,ballMid;
	
	public Text levelNum;

	void Start () 
	{
		//PlayerPrefs.DeleteAll();
		//PlayerPrefs.SetInt("levelNum",5);
		game_ref=this;
		for(int i=0;i<levels.Length;i++)
		{
			levels[i].SetActive(false);
		}
		levels[PlayerPrefs.GetInt("levelNum")].SetActive(true);
		player.SetActive(true);
		player.GetComponent<MeshRenderer>().material=ballMat[PlayerPrefs.GetInt("levelNum")];
		Material[] matArray = player.GetComponent<MeshRenderer>().materials;
 		matArray[1] = ballMid[PlayerPrefs.GetInt("levelNum")];
 		player.GetComponent<MeshRenderer>().materials = matArray;
		player.GetComponent<TrailRenderer>().material=ballMat[PlayerPrefs.GetInt("levelNum")];
		bg.SetActive(true);

		bg.GetComponent<Renderer>().material=materials[PlayerPrefs.GetInt("levelNum")];
		levelComplete.SetActive(false);
		Ingame.SetActive(true);
		levelNum.text="Level "+(PlayerPrefs.GetInt("levelNum")+1).ToString();
	
	}
	


	void Update () {
		
	}

	
	public void Retry()
	{
		
		Application.LoadLevel("SampleScene");
		FindObjectOfType<AdManager>().ShowAd();
	} 
	public void Next()
	{
	//	PlayerPrefs.SetInt("levelNum",PlayerPrefs.GetInt("levelNum")+1);
		Application.LoadLevel("SampleScene");
	}

	public void Home()
	{
		Application.LoadLevel("MainMenu");
	}

}
