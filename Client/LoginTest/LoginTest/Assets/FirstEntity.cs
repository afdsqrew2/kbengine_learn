using System.Collections;
using System.Collections.Generic;
using KBEngine;
using UnityEngine;

public class FirstEntity : FirstEntityBase
{
    public override void onEnter()
    {
        //throw new System.NotImplementedException();
        Debug.Log("----Unity onEnter");
    }

    public override void onSay(string arg1)
    {
        //throw new System.NotImplementedException();
        Debug.Log("----Unity onSay");
    }
}
