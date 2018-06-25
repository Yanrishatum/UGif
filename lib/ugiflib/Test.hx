package ugiflib;

class Test
{
  public static function main()
  {
    var io = sys.io.File.getBytes("jump_fall.gif");
    var file = UGifLib.read(io);
    trace(file.width, file.height, file.frames);
    var out = sys.io.File.write("jump_fall.edit.gif");
    new format.png.Writer(out).write(format.png.Tools.build32BGRA(file.width * file.frames.length, file.height, file.picture));
    out.close();
  }
}