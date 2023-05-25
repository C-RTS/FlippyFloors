/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件由会员免费分享，如果商用，请务必联系原著购买授权！

daily assets update for try.

U should buy a license from author if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class SampleInfo : MonoBehaviour
{
void OnGUI(){
		GUILayout.Label("iTween can spin, shake, punch, move, handle audio, fade color and transparency \nand much more with each task needing only one line of code.");
		GUILayout.BeginHorizontal();
		GUILayout.Label("iTween works with C#, JavaScript and Boo. For full documentation and examples visit:");
		if(GUILayout.Button("http://itween.pixelplacement.com")){
			Application.OpenURL("http://itween.pixelplacement.com");
		}
		GUILayout.EndHorizontal();
	}
}

