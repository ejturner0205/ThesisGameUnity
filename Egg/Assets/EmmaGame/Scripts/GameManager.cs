using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager ins;
    public IVCanvas ivCanvas;

   [HideInInspector]
    public Node currentNode;
    public Node startingNode;

    //singleton
    private void Awake()
    {
        ins = this;
        ivCanvas.gameObject.SetActive(false);
    }

    private void Start()
    {
        startingNode.Arrive();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1) && currentNode.GetComponent<Prop>() != null)
        {
            if (ivCanvas.gameObject.activeInHierarchy)
            {
                ivCanvas.Close();
                return;
            }
            currentNode.GetComponent<Prop>().loc.Arrive();
        }
    }
}
