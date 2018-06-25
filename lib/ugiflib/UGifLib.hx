package ugiflib;

import haxe.io.Bytes;
import format.gif.Data;
import format.gif.Reader;
import format.gif.Tools;
#if cs
import cs.NativeArray;
typedef CSArray = cs.NativeArray<Int>;
#else
typedef CSArray = haxe.ds.Vector<Int>;
#end

@:keep
class UGifLib
{

  public static function read(source:Bytes):UGifFile
  {
    var data:Data = new Reader(new CSInput(source)).read();
    var fc:Int = Tools.framesCount(data);
    var width:Int = data.logicalScreenDescriptor.width;
    var lineWidth:Int = width * fc * 4;
    var height:Int = data.logicalScreenDescriptor.height;
    var outBytes:Bytes = Bytes.alloc((fc * width) * height * 4);
    
    var file = new UGifFile(outBytes, width, height, fc);
    
    for (i in 0...fc)
    {
      var gce:GraphicControlExtension = Tools.graphicControl(data, i);
      var frameData = Tools.extractFullRGBA(data, i);
      for (j in 0...height)
      {
        outBytes.blit((lineWidth * (height - j - 1)) + (width * i * 4), frameData, j * width * 4, width * 4);
      }
      if (gce == null) file.frames[i] = 1;
      else file.frames[i] = gce.delay;
    }
    
    return file;
  }

}

class UGifFile
{
  public var width:Int;
  public var height:Int;
  public var picture:Bytes;
  public var frames:CSArray;
  
  public function new(data:Bytes, w:Int, h:Int, fc:Int)
  {
    width = w;
    height = h;
    picture = data;
    frames = new CSArray(fc);
  }
  
}

class CSInput extends haxe.io.Input
{
  private var b:Bytes;
  private var pos:Int;
  
  public function new(b:Bytes)
  {
    this.b = b;
    this.pos = 0;
  }

  public override function readByte():Int
  {
    return b.get(pos++);
  }

}