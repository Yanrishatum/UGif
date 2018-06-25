using System;
using UnityEngine;
using UnityEditor;
using System.IO;
using ugiflib;
using System.Linq;

namespace UGif
{
  public class UGifWindow : EditorWindow
  {
    
    private float delay = 0.5f;

    public UGifWindow() : base()
    {
      titleContent.text = "UGif Settings";
    }
    
    [MenuItem("Window/UGif")]
    public static void ShowUGif()
    {
      EditorWindow.GetWindow(typeof(UGifWindow));
    }
    
    private void OnDisable()
    {
      UGifShared.SaveSettings();
    }
    
    private void OnGUI()
    {
      GUILayout.Label("Settings", EditorStyles.boldLabel);

      GUILayout.BeginHorizontal();

      UGifShared.settings.generateAnim = GUILayout.Toggle(UGifShared.settings.generateAnim, "Generate animations");
      UGifShared.settings.printLog = GUILayout.Toggle(UGifShared.settings.printLog, "Print Log");

      GUILayout.EndHorizontal();

      UGifShared.settings.pixelsPerUnit = EditorGUILayout.FloatField("Import PixelsPerUnit", UGifShared.settings.pixelsPerUnit);

      UGifShared.settings.configureAllTextures = GUILayout.Toggle(UGifShared.settings.configureAllTextures, "Apply configuration to all textures");
      GUILayout.Label("Manual animation generation", EditorStyles.boldLabel);

      delay = EditorGUILayout.FloatField("Frame delay", delay);
      object toGen = EditorGUILayout.ObjectField(null, typeof(Texture2D), false);

      if (toGen != null)
      {
        Texture2D tex = (Texture2D)toGen;
        Sprite[] sprites = AssetDatabase.LoadAllAssetsAtPath(tex.name).OfType<Sprite>().ToArray();
        
        float[] delays = new float[sprites.Length];
        for (int i = 0; i < sprites.Length; i++)
        {
          delays[i] = delay;
        }
        UGifShared.CreateAnimation(AssetDatabase.GetAssetPath(tex), sprites, delays, true);
      }
      //Rect dropArea = GUILayoutUtility.GetRect(0.0f, 0.0f, [GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true)]);
      //GUILayout.Box(dropArea, "Drag&Drop to generate animation");

    }
    
  }
}
