using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prerequisite : MonoBehaviour
{

    public Switcher watchSwitcher;
    public bool nodeAccess;
    public bool Complete
    {
        get { return watchSwitcher.state; }
    }

}
