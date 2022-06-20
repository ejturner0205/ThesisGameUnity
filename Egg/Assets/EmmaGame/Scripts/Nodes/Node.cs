using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public abstract class Node : MonoBehaviour
{

    public Transform cameraPosition;
    public List<Node> reachableNodes = new List<Node>();
    public float FOV;

    [HideInInspector]
    public Collider2D col;

    void Awake()
    {
        col = GetComponent<Collider2D>();
        col.enabled = false;
    }
    private void OnMouseDown()
    {
        Arrive();
    }

    public virtual void Arrive()
    {
        //leave existing currentNode
       if(GameManager.ins.currentNode != null)
        GameManager.ins.currentNode.Leave();
        //set current node
        GameManager.ins.currentNode = this;

        //move camera
        Sequence seq = DOTween.Sequence();
        seq.Append(Camera.main.transform.DOMove(cameraPosition.position, 0.75f));
        seq.Join(Camera.main.DOOrthoSize(FOV,0.75f));

        //turn off collider
        if (col != null)
            col.enabled = false;

        //turn on all reachable node collider
        SetReachableNodes(true);
    }
    public virtual void Leave()
    {
        SetReachableNodes(false);
    }
    public void SetReachableNodes(bool set)
    {
        foreach (Node node in reachableNodes)
        {
            if (node.col != null)
                if (node.GetComponent<Prerequisite>() && node.GetComponent<Prerequisite>().nodeAccess)
                {
                    if (node.GetComponent<Prerequisite>().Complete)
                    {
                        node.col.enabled = set;
                    }
                }
                else
                {
                    node.col.enabled = set;
                }
        }
    }
}
