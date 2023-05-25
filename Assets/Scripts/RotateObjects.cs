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

public class RotateObjects : MonoBehaviour
 {
[SerializeField] private float rotateSpeed;
void Update () 
{
     if(Input.touchCount>0&&Input.GetTouch(0).phase==TouchPhase.Moved)//||Input.GetMouseButton(0)
         this.transform.Rotate(Vector3.forward*rotateSpeed*Input.GetAxis("Mouse X"));
    //this.transform.eulerAngles = new Vector3 (this.transform.eulerAngles.x,this.transform.eulerAngles.y,-SteeringWheel.rotationAxis.z);
}
   
}
