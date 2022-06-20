using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IVCanvas : MonoBehaviour
{
    public Image imageholder;

    public void Activate(Sprite pic)
    {
        GameManager.ins.currentNode.SetReachableNodes(false);
        GameManager.ins.currentNode.col.enabled = false;
        gameObject.SetActive(true);
        imageholder.sprite = pic;
    }
    public void Close()
    {
        GameManager.ins.currentNode.SetReachableNodes(true);
        GameManager.ins.currentNode.col.enabled = true;
        gameObject.SetActive(false);
        imageholder.sprite = null;
    }

}
