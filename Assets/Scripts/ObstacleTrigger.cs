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

public class ObstacleTrigger : MonoBehaviour {

	// Use this for initialization
	public GameObject explosionPrefab;
	public Color color;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

void OnCollisionEnter(Collision other)
{
	if(other.gameObject.tag=="Player")
	{
	
	 	ContactPoint contact = other.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        GameObject effect=Instantiate(explosionPrefab, new Vector3(pos.x,pos.y,0), rot);
		effect.GetComponent<ParticleSystem>().startColor=color;
		other.gameObject.SetActive(false);
       
		Invoke("Retry",2f);
	}
}
void Retry()
{
	Application.LoadLevel("SampleScene");
}

	
}
