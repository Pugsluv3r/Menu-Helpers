using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static Your.Menu.SimpleInputs;
namespace Your.menuhere
{
//simple inputs is used
internal class RigMods
  {
              public static void Grabrig()
        {
            if (RightGrab)
            {
                VRRig.LocalRig.enabled = false;

                VRRig.LocalRig.transform.position = GorillaTagger.Instance.rightHandTransform.position;

            }
            else
            {
                VRRig.LocalRig.enabled = true;
            }
                 public static void Ghost()
            {
               if (RightTrigger)
            {
              VRRig.LocalRig.enabled = false;
            }
            else
            {
              VRRig.LocalRig.enabled = true;
            }
        }
    } 
}
