using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteReactor : StateReactor
{
    public Sprite active;
    public Sprite inactive;
    SpriteRenderer image;

    protected override void Awake()
    {
        base.Awake();
       image = GetComponent<SpriteRenderer>();
        React();
    }

    public override void React()
    {
        if (switcher.state)
        {
            image.sprite = active;
        }
        else
        {
            image.sprite = inactive;
        }
    }
}