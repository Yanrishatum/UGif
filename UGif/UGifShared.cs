using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
using ugiflib;
using System.IO;

namespace UGif
{
  class UGifShared
  {

    static UGifShared()
    {
      settings = new UGifSettings();
      if (EditorPrefs.GetInt(UGifSettings.VERSION_KEY, 0) == UGifSettings.VERSION)
      {
        string data = EditorPrefs.GetString(UGifSettings.SETTINGS_KEY);
        if (data != null)
        {
          JsonUtility.FromJsonOverwrite(data, settings);
        }
      }
      EditorApplication.update += CheckAnimImportQueue;
    }

    public static void CheckAnimImportQueue()
    {
      if (UGifShared.animImport.Count > 0)
      {
        AssetDatabase.StartAssetEditing();

        foreach (string k in UGifShared.animImport.Keys)
        {
          UGifShared.animImport.TryGetValue(k, out UGifFile file);

          float[] delays = new float[file.frames.Length];
          for (int i = 0; i < delays.Length; i++) delays[i] = (float)file.frames[i] / 100f;
          Sprite[] sprites = AssetDatabase.LoadAllAssetsAtPath(k).OfType<Sprite>().ToArray();
          CreateAnimation(k, sprites, delays, false);
        }

        UGifShared.animImport.Clear();

        AssetDatabase.StopAssetEditing();

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

      }
    }



    public static void CreateAnimation(string texturePath, Sprite[] sprites, float[] delays, bool save)
    {
      if (settings.printLog) Debug.Log("Creating animation for: " + texturePath);
      
      string clipPath = Path.ChangeExtension(texturePath, ".anim");
      AnimationClip clip = AssetDatabase.LoadAssetAtPath<AnimationClip>(clipPath);
      bool newAsset = clip == null;
      if (newAsset)
      {
        clip = new AnimationClip
        {
          frameRate = 100
        };

        AnimationClipSettings settings = new AnimationClipSettings
        {
          loopTime = true
        };
        AnimationUtility.SetAnimationClipSettings(clip, settings);
      }
      else
      {
        clip.ClearCurves();
        clip.frameRate = 100;
      }


      EditorCurveBinding binding = new EditorCurveBinding
      {
        type = typeof(SpriteRenderer),
        path = "",
        propertyName = "m_Sprite"
      };

      ObjectReferenceKeyframe[] keyframes = new ObjectReferenceKeyframe[sprites.Length + 1];
      float frame = 0;

      for (int i = 0; i < sprites.Length; i++)
      {
        keyframes[i] = new ObjectReferenceKeyframe
        {
          time = frame, // to s
          value = sprites[i]
        };
        frame += delays[i];
      }
      // Revert to first frame.
      if (sprites.Length > 1)
      {
        keyframes[sprites.Length] = new ObjectReferenceKeyframe
        {
          time = (float)frame / (float)100.0,
          value = sprites[0]
        };
      }
      
      AnimationUtility.SetObjectReferenceCurve(clip, binding, keyframes);

      if (newAsset)
      {
        AssetDatabase.CreateAsset(clip, clipPath);
      }
      else
      {
        EditorUtility.SetDirty(clip);
      }

      if (save)
      {
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
      }
    }

    public static void SaveSettings()
    {
      EditorPrefs.SetInt(UGifSettings.VERSION_KEY, UGifSettings.VERSION);
      EditorPrefs.SetString(UGifSettings.SETTINGS_KEY, JsonUtility.ToJson(settings));
    }

    public static UGifSettings settings;

    public static Dictionary<string, UGifFile> animImport = new Dictionary<string, UGifFile>();

  }

  class UGifSettings
  {

    public static readonly string SETTINGS_KEY = "UGif.settings";
    public static readonly string VERSION_KEY = "UGif.version";
    public static readonly int VERSION = 1;

    [SerializeField] public bool generateAnim = true;
    [SerializeField] public bool printLog = true;

    [SerializeField] public float pixelsPerUnit = 16;
    [SerializeField] public bool configureAllTextures = true;

  }

}
