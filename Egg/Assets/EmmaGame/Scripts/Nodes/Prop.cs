using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : Node
{
    public Location loc;
    Interactables inter;

    private void Start()
    {
        inter = GetComponent<Interactables>();
    }

    public override void Arrive()
    {
        if (inter != null && inter.enabled)
        {
            inter.Interact();
            return;
        }

        base.Arrive();

        //make object interactable if prerequisite is met
        if(inter != null)
        {
            if (GetComponent<Prerequisite>() && !GetComponent<Prerequisite>().Complete) {
                return;
            }
            col.enabled = true;


            inter.enabled = true;
        }

    }
    public override void Leave()
    {
        base.Leave();

        if(inter != null)
        {
            inter.enabled = false;
        }
    }
}
