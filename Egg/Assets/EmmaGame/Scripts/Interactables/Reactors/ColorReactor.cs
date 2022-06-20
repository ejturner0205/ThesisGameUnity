using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class ColorReactor : StateReactor
{
    public Color active;
    public Color inactive;
    SpriteRenderer sprite;

    protected override void Awake()
    {
        base.Awake();
        sprite = GetComponent<SpriteRenderer>();
        React();
    }

    public override void React()
    {
        if (switcher.state)
        {
            sprite.color = active;
        }
        else
        {
            sprite.color = inactive;
        }
    }
}
