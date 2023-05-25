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

public class CamFollower : MonoBehaviour {

	// Use this for initialization
	public Transform playerTrans  ;
	Transform thisTrans ;
	public Vector3 Offset;
	void Start () {
		thisTrans = transform;
		//playerTrans = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void LateUpdate () {

		thisTrans.position = Vector3.Lerp (thisTrans.position, playerTrans.position + Offset,Time.deltaTime*50);
	}
}
