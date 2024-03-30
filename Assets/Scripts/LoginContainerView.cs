using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginContainerView : ContainerView
{
    public void BackSettings()
    {
        Manager.Show<SettingsContainerView>();
    }
}
