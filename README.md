# UGif
Unity animated gifs importer plugin

## Method of operation
Plugin interrupts the importing process of gif files and converts imported textures to horizontal spritesheets, alongside with generated AnimationClip.  
This plugin was made tailored for specific needs (as in - pixel graphics) and won't be suitable for everyone.  
Plugin preconfigures texture for Sprite type, RGBA32 format, point filtering and set pixelsPerUnit to value in settings (default: 16).

## Options
You can open settings window under Window/UGif button.
* Generate animation: Should plugin generate AnimationClips for gifs. Note that generated animations regard the frame delays set up in the gif files.
* Print Log: Plugin will print debug messages during import process.
* Apply configuration to all textures: Will apply same settings to all imported textures (pixelsPerUnit, Sprite type, point filter), not only gifs.
* Import PixelsPerUnit: The value applied to texture PixelsPerUnit during import.

### Manual animation generator
Settings window also provides manual generator for AnimationClips. This method method does not regards gif frame delays and places all sprites in texture with same spacing set in `Frame delay`. Just select texture you want generate animation for.

## Building from source
For plugin you just need Visual Studio and Unity installed. If you want to modify the `ugiflib` sources, you will ned Haxe with `format` and `hxcs` libraries installed.

## License
This work is under MIT License, see license file for details.