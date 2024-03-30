using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainContainerView : ContainerView
{
    public void GoSettings()
    {
        Manager.Show<SettingsContainerView>();
    }
}
