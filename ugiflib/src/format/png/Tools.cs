// Generated by Haxe 4.0.0 (git build development @ 3018ab109)
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.png {
	public class Tools : global::haxe.lang.HxObject {
		
		public Tools(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Tools() {
			global::format.png.Tools.__hx_ctor_format_png_Tools(this);
		}
		
		
		protected static void __hx_ctor_format_png_Tools(global::format.png.Tools __hx_this) {
		}
		
		
		public static global::haxe.ds.List<object> build32BGRA(int width, int height, global::haxe.io.Bytes data, global::haxe.lang.Null<int> level) {
			unchecked {
				global::haxe.lang.Null<int> level1 = ( ( ! (level.hasValue) ) ? (new global::haxe.lang.Null<int>(9, true)) : (level) );
				global::haxe.io.Bytes rgba = global::haxe.io.Bytes.alloc(( ( ( width * height ) * 4 ) + height ));
				int w = 0;
				int r = 0;
				{
					int _g1 = 0;
					int _g = height;
					while (( _g1 < _g )) {
						int y = _g1++;
						rgba.b[w++] = ((byte) (0) );
						{
							int _g3 = 0;
							int _g2 = width;
							while (( _g3 < _g2 )) {
								int x = _g3++;
								rgba.b[w++] = ((byte) (((int) (data.b[( r + 2 )]) )) );
								rgba.b[w++] = ((byte) (((int) (data.b[( r + 1 )]) )) );
								rgba.b[w++] = ((byte) (((int) (data.b[r]) )) );
								rgba.b[w++] = ((byte) (((int) (data.b[( r + 3 )]) )) );
								r += 4;
							}
							
						}
						
					}
					
				}
				
				global::haxe.ds.List<object> l = new global::haxe.ds.List<object>();
				object __temp_stmt2 = null;
				{
					global::format.png.Color __temp_odecl1 = global::format.png.Color.ColTrue(true);
					__temp_stmt2 = new global::haxe.lang.DynamicObject(new int[]{1247572323, 1501088657}, new object[]{__temp_odecl1, false}, new int[]{38537191, 1247983110, 1724357446}, new double[]{((double) (height) ), ((double) (width) ), ((double) (8) )});
				}
				
				l.@add(global::format.png.Chunk.CHeader(__temp_stmt2));
				l.@add(global::format.png.Chunk.CData(global::format.tools.Deflate.run(rgba, level1)));
				l.@add(global::format.png.Chunk.CEnd);
				return l;
			}
		}
		
		
	}
}


