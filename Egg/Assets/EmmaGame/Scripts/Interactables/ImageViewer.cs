using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageViewer : Interactables
{
    public Sprite pic;
    public override void Interact()
    {
        GameManager.ins.ivCanvas.Activate(pic);
    }

}
