﻿using Android.App;
using Android.Content.PM;

namespace Maui.Widgets;

[
    Activity
        (
            Theme = "@style/Maui.SplashTheme", 
            MainLauncher = true,
            Exported = true,
            ConfigurationChanges = ConfigChanges.ScreenSize | 
                                   ConfigChanges.Orientation | 
                                   ConfigChanges.UiMode | 
                                   ConfigChanges.ScreenLayout | 
                                   ConfigChanges.SmallestScreenSize | 
                                   ConfigChanges.Density
        )
]
public class MainActivity : MauiAppCompatActivity
{
}
