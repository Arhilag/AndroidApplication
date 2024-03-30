using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GalleryItem : MonoBehaviour
{
    [SerializeField] private Image _image;
    public Image Image => _image;

    public void Select()
    {
        ChangeWallpaper(_image.sprite);
    }
    private void ChangeWallpaper(Sprite wallpaperSprite) 
    { 
        Texture2D wallpaperTexture = wallpaperSprite.texture; 
        
        AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"); 
        AndroidJavaObject currentActivity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity"); 
        
        AndroidJavaClass wallpaperManagerClass = new AndroidJavaClass("android.app.WallpaperManager"); 
        AndroidJavaObject wallpaperManager = wallpaperManagerClass.CallStatic<AndroidJavaObject>("getInstance", currentActivity); 
 
        byte[] wallpaperBytes = wallpaperTexture.EncodeToPNG();
 
        AndroidJavaClass bitmapFactoryClass = new AndroidJavaClass("android.graphics.BitmapFactory"); 
        AndroidJavaObject bitmap = bitmapFactoryClass.CallStatic<AndroidJavaObject>("decodeByteArray", wallpaperBytes, 0, wallpaperBytes.Length); 
 
        wallpaperManager.Call("setBitmap", bitmap); 
        wallpaperManager.Call("setWallpaperOffsetSteps", 1f, 1f); 
        wallpaperManager.Call("suggestDesiredDimensions", Screen.width, Screen.height); 
        
        currentActivity.Call("runOnUiThread", new AndroidJavaRunnable(() => 
        { 
            wallpaperManager.Call("clearWallpaperOffsets"); 
        })); 
    } 
}
