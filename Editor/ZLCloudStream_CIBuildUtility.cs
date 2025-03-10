using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZeroLight;

namespace ZeroLight
{

    public class ZLCloudStream_CIBuildUtility
    {
        public static void CI_TriggerBuild()
        {
            Debug.Log("OmniStream CI Build & Deploy - Starting build");
            ZLCloudStreamPluginWindow.CI_TriggerBuildAndDeploy();
        }
    }

}
