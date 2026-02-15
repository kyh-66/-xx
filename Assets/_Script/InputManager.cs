using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManger : MonoBehaviour
{
    [SerializeField] private Camera sceneCamera;//检测鼠标的位置

    private Vector3 lastPosition;

    [SerializeField] private LayerMask placementLayermask;//检测的层


    public Vector3 GetSelectedMapPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = sceneCamera.nearClipPlane;//设置鼠标位置的z轴为相机的高度
        Ray ray = sceneCamera.ScreenPointToRay(mousePos);//从相机发出一条射线，穿过鼠标位置
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100, placementLayermask))//检测射线是否与指定层相交
        {
            lastPosition = hit.point;
        }
        return lastPosition;
    }

}