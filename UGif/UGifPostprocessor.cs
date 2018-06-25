using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
using System.IO;
using ugiflib;

namespace UGif
{
  class UGifPostprocessor : AssetPostprocessor
  {

    private Dictionary<string, UGifFile> importCache = new Dictionary<string, UGifFile>();

    UGifFile getUGif()
    {
      byte[] data = File.ReadAllBytes(assetPath);
      haxe.io.Bytes b = new haxe.io.Bytes(data.Length, data);
      return UGifLib.read(b);
    }

    void OnPreprocessTexture()
    {
      bool isGif = Path.GetExtension(assetPath) == ".gif";
      TextureImporter imp = (TextureImporter)assetImporter;
      if (UGifShared.settings.configureAllTextures || isGif)
      {
        imp.textureType = TextureImporterType.Sprite;
        imp.filterMode = FilterMode.Point;
        imp.alphaIsTransparency = true;
        imp.spritePixelsPerUnit = UGifShared.settings.pixelsPerUnit;
      }

      if (isGif)
      {
        imp.mipmapEnabled = false;
        imp.textureFormat = TextureImporterFormat.RGBA32;
        imp.spriteImportMode = SpriteImportMode.Multiple;
        importCache.Add(assetPath, getUGif());
      }
    }

    void OnPostprocessTexture(Texture2D t)
    {
      if (importCache.TryGetValue(assetPath, out UGifFile file))
      {
        t.Resize(file.width * file.frames.Length, file.height, TextureFormat.RGBA32, false);
        t.LoadRawTextureData(file.picture.b);

        TextureImporter imp = (TextureImporter)assetImporter;
        SpriteMetaData[] sprites = new SpriteMetaData[file.frames.Length];
        string nameBase = Path.GetFileNameWithoutExtension(assetPath);

        for (int i = 0; i < sprites.Length; i++)
        {
          sprites[i] = new SpriteMetaData()
          {
            name = nameBase + "_" + i,
            border = new Vector4(0, 0, 0, 0),
            pivot = new Vector2(file.width / 2, file.height / 2),
            rect = new Rect(i * file.width, 0, file.width, file.height)
          };
        }

        imp.spritesheet = sprites;

        if (UGifShared.settings.printLog) Debug.Log("Importing gif! " + assetPath + " [" + file.width + "x" + file.height + "@" + file.frames.Length + "]");

      }
    }

    void OnPostprocessSprites(Texture2D t, Sprite[] sprites)
    {
      importCache.TryGetValue(assetPath, out UGifFile file);
      if (file == null) return;
      importCache.Remove(assetPath);
      if (UGifShared.settings.generateAnim) UGifShared.animImport.Add(assetPath, file);

    }

  }
  

}
