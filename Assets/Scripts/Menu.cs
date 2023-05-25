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

public class Menu : MonoBehaviour 
{
	public static Menu menu_ref;
	public GameObject menu,levelselection,loading;
	
	void Start()
	{
		
			menu_ref = this;
		
		MainMenu();
	}

public void MainMenu()
{
	menu.SetActive(true);
	levelselection.SetActive(false);
	loading.SetActive(false);

}

public void LevelSel()
{
	menu.SetActive(false);
	levelselection.SetActive(true);
	loading.SetActive(false);
}
public void Loading()
{
	menu.SetActive(false);
	levelselection.SetActive(false);
	loading.SetActive(true);
}
	
}
