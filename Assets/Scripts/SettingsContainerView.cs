using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsContainerView : ContainerView
{
    public void GoLogin()
    {
        Manager.Show<LoginContainerView>();
    }

    public void BackMain()
    {
        Manager.Show<MainContainerView>();
    }
}
