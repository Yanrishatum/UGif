// Generated by Haxe 4.0.0 (git build development @ 3018ab109)
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public class Tools : global::haxe.lang.HxObject {
		
		static Tools() {
			unchecked {
				global::format.gif.Tools.LN2 = global::System.Math.Log(((double) (2) ));
			}
		}
		
		
		public Tools(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Tools() {
			global::format.gif.Tools.__hx_ctor_format_gif_Tools(this);
		}
		
		
		protected static void __hx_ctor_format_gif_Tools(global::format.gif.Tools __hx_this) {
		}
		
		
		public static int framesCount(object data) {
			int frames = 0;
			{
				global::haxe.ds._List.ListNode<object> _g_head = ((global::haxe.ds.List<object>) (global::haxe.ds.List<object>.__hx_cast<object>(((global::haxe.ds.List) (global::haxe.lang.Runtime.getField(data, "blocks", 669658758, true)) ))) ).h;
				while (( _g_head != null )) {
					global::format.gif.Block val = ((global::format.gif.Block) (_g_head.item) );
					_g_head = _g_head.next;
					global::format.gif.Block block = ((global::format.gif.Block) (val) );
					if (( block._hx_index == 0 )) {
						 ++ frames;
					}
					
				}
				
			}
			
			return frames;
		}
		
		
		public static object frame(object data, int frameIndex) {
			int counter = 0;
			{
				global::haxe.ds._List.ListNode<object> _g_head = ((global::haxe.ds.List<object>) (global::haxe.ds.List<object>.__hx_cast<object>(((global::haxe.ds.List) (global::haxe.lang.Runtime.getField(data, "blocks", 669658758, true)) ))) ).h;
				while (( _g_head != null )) {
					global::format.gif.Block val = ((global::format.gif.Block) (_g_head.item) );
					_g_head = _g_head.next;
					global::format.gif.Block block = ((global::format.gif.Block) (val) );
					if (( block._hx_index == 0 )) {
						object frame = ( block as global::format.gif.Block_BFrame ).frame;
						{
							if (( counter == frameIndex )) {
								return frame;
							}
							
							 ++ counter;
						}
						
					}
					
				}
				
			}
			
			return null;
		}
		
		
		public static object graphicControl(object data, int frameIndex) {
			unchecked {
				int counter = 0;
				object gce = null;
				{
					global::haxe.ds._List.ListNode<object> _g_head = ((global::haxe.ds.List<object>) (global::haxe.ds.List<object>.__hx_cast<object>(((global::haxe.ds.List) (global::haxe.lang.Runtime.getField(data, "blocks", 669658758, true)) ))) ).h;
					while (( _g_head != null )) {
						global::format.gif.Block val = ((global::format.gif.Block) (_g_head.item) );
						_g_head = _g_head.next;
						global::format.gif.Block block = ((global::format.gif.Block) (val) );
						switch (block._hx_index) {
							case 0:
							{
								object frame = ( block as global::format.gif.Block_BFrame ).frame;
								{
									if (( counter == frameIndex )) {
										return gce;
									}
									
									gce = null;
									 ++ counter;
								}
								
								break;
							}
							
							
							case 1:
							{
								if (( ( block as global::format.gif.Block_BExtension ).extension._hx_index == 0 )) {
									object g = ( ( block as global::format.gif.Block_BExtension ).extension as global::format.gif.Extension_EGraphicControl ).gce;
									gce = g;
								}
								
								break;
							}
							
							
							default:
							{
								break;
							}
							
						}
						
					}
					
				}
				
				return null;
			}
		}
		
		
		public static global::haxe.io.Bytes extractBGRA(object data, int frameIndex) {
			unchecked {
				object gce = null;
				int frameCaret = 0;
				{
					global::haxe.ds._List.ListNode<object> _g_head = ((global::haxe.ds.List<object>) (global::haxe.ds.List<object>.__hx_cast<object>(((global::haxe.ds.List) (global::haxe.lang.Runtime.getField(data, "blocks", 669658758, true)) ))) ).h;
					while (( _g_head != null )) {
						global::format.gif.Block val = ((global::format.gif.Block) (_g_head.item) );
						_g_head = _g_head.next;
						global::format.gif.Block block = ((global::format.gif.Block) (val) );
						switch (block._hx_index) {
							case 0:
							{
								object frame = ( block as global::format.gif.Block_BFrame ).frame;
								{
									if (( frameCaret == frameIndex )) {
										global::haxe.io.Bytes bytes = global::haxe.io.Bytes.alloc(( ( ((int) (global::haxe.lang.Runtime.getField_f(frame, "width", 1247983110, true)) ) * ((int) (global::haxe.lang.Runtime.getField_f(frame, "height", 38537191, true)) ) ) * 4 ));
										global::haxe.io.Bytes ct = ( (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.getField(frame, "localColorTable", 706588918, true))) ? (((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(frame, "colorTable", 793759659, true)) )) : (((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(data, "globalColorTable", 146652910, true)) )) );
										if (( ct == null )) {
											throw global::haxe.lang.HaxeException.wrap("Frame does not have a color table!");
										}
										
										int transparentIndex = ( (( ((bool) (( gce != null )) ) && global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.getField(gce, "hasTransparentColor", 755457067, true)) )) ? (( ((int) (global::haxe.lang.Runtime.getField_f(gce, "transparentIndex", 772773472, true)) ) * ((int) (3) ) )) : (-1) );
										int writeCaret = 0;
										{
											int _g1 = 0;
											int _g = ((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(frame, "pixels", 212463405, true)) ).length;
											while (( _g1 < _g )) {
												int i = _g1++;
												int index = ( ((int) (((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(frame, "pixels", 212463405, true)) ).b[i]) ) * 3 );
												bytes.b[writeCaret] = ((byte) (((int) (ct.b[( index + 2 )]) )) );
												bytes.b[( writeCaret + 1 )] = ((byte) (((int) (ct.b[( index + 1 )]) )) );
												bytes.b[( writeCaret + 2 )] = ((byte) (((int) (ct.b[index]) )) );
												if (( transparentIndex == index )) {
													bytes.b[( writeCaret + 3 )] = ((byte) (0) );
												}
												else {
													bytes.b[( writeCaret + 3 )] = ((byte) (255) );
												}
												
												writeCaret += 4;
											}
											
										}
										
										return bytes;
									}
									
									 ++ frameCaret;
									gce = null;
								}
								
								break;
							}
							
							
							case 1:
							{
								global::format.gif.Extension ext = ( block as global::format.gif.Block_BExtension ).extension;
								if (( ext._hx_index == 0 )) {
									object g = ( ext as global::format.gif.Extension_EGraphicControl ).gce;
									gce = g;
								}
								
								break;
							}
							
							
							default:
							{
								break;
							}
							
						}
						
					}
					
				}
				
				return null;
			}
		}
		
		
		public static global::haxe.io.Bytes extractRGBA(object data, int frameIndex) {
			unchecked {
				object gce = null;
				int frameCaret = 0;
				{
					global::haxe.ds._List.ListNode<object> _g_head = ((global::haxe.ds.List<object>) (global::haxe.ds.List<object>.__hx_cast<object>(((global::haxe.ds.List) (global::haxe.lang.Runtime.getField(data, "blocks", 669658758, true)) ))) ).h;
					while (( _g_head != null )) {
						global::format.gif.Block val = ((global::format.gif.Block) (_g_head.item) );
						_g_head = _g_head.next;
						global::format.gif.Block block = ((global::format.gif.Block) (val) );
						switch (block._hx_index) {
							case 0:
							{
								object frame = ( block as global::format.gif.Block_BFrame ).frame;
								{
									if (( frameCaret == frameIndex )) {
										global::haxe.io.Bytes bytes = global::haxe.io.Bytes.alloc(( ( ((int) (global::haxe.lang.Runtime.getField_f(frame, "width", 1247983110, true)) ) * ((int) (global::haxe.lang.Runtime.getField_f(frame, "height", 38537191, true)) ) ) * 4 ));
										global::haxe.io.Bytes ct = ( (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.getField(frame, "localColorTable", 706588918, true))) ? (((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(frame, "colorTable", 793759659, true)) )) : (((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(data, "globalColorTable", 146652910, true)) )) );
										if (( ct == null )) {
											throw global::haxe.lang.HaxeException.wrap("Frame does not have a color table!");
										}
										
										int transparentIndex = ( (( ((bool) (( gce != null )) ) && global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.getField(gce, "hasTransparentColor", 755457067, true)) )) ? (( ((int) (global::haxe.lang.Runtime.getField_f(gce, "transparentIndex", 772773472, true)) ) * ((int) (3) ) )) : (-1) );
										int writeCaret = 0;
										{
											int _g1 = 0;
											int _g = ((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(frame, "pixels", 212463405, true)) ).length;
											while (( _g1 < _g )) {
												int i = _g1++;
												int index = ( ((int) (((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(frame, "pixels", 212463405, true)) ).b[i]) ) * 3 );
												bytes.b[writeCaret] = ((byte) (((int) (ct.b[index]) )) );
												bytes.b[( writeCaret + 1 )] = ((byte) (((int) (ct.b[( index + 1 )]) )) );
												bytes.b[( writeCaret + 2 )] = ((byte) (((int) (ct.b[( index + 2 )]) )) );
												if (( transparentIndex == index )) {
													bytes.b[( writeCaret + 3 )] = ((byte) (0) );
												}
												else {
													bytes.b[( writeCaret + 3 )] = ((byte) (255) );
												}
												
												writeCaret += 4;
											}
											
										}
										
										return bytes;
									}
									
									 ++ frameCaret;
									gce = null;
								}
								
								break;
							}
							
							
							case 1:
							{
								global::format.gif.Extension ext = ( block as global::format.gif.Block_BExtension ).extension;
								if (( ext._hx_index == 0 )) {
									object g = ( ext as global::format.gif.Extension_EGraphicControl ).gce;
									gce = g;
								}
								
								break;
							}
							
							
							default:
							{
								break;
							}
							
						}
						
					}
					
				}
				
				return null;
			}
		}
		
		
		public static global::haxe.io.Bytes extractFullBGRA(object data, int frameIndex) {
			unchecked {
				object gce = null;
				int frameCaret = 0;
				global::haxe.io.Bytes bytes = global::haxe.io.Bytes.alloc(( ( ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(data, "logicalScreenDescriptor", 2032764644, true), "width", 1247983110, true)) ) * ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(data, "logicalScreenDescriptor", 2032764644, true), "height", 38537191, true)) ) ) * 4 ));
				{
					global::haxe.ds._List.ListNode<object> _g_head = ((global::haxe.ds.List<object>) (global::haxe.ds.List<object>.__hx_cast<object>(((global::haxe.ds.List) (global::haxe.lang.Runtime.getField(data, "blocks", 669658758, true)) ))) ).h;
					while (( _g_head != null )) {
						global::format.gif.Block val = ((global::format.gif.Block) (_g_head.item) );
						_g_head = _g_head.next;
						global::format.gif.Block block = ((global::format.gif.Block) (val) );
						switch (block._hx_index) {
							case 0:
							{
								object frame = ( block as global::format.gif.Block_BFrame ).frame;
								{
									global::haxe.io.Bytes ct = ( (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.getField(frame, "localColorTable", 706588918, true))) ? (((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(frame, "colorTable", 793759659, true)) )) : (((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(data, "globalColorTable", 146652910, true)) )) );
									if (( ct == null )) {
										throw global::haxe.lang.HaxeException.wrap("Frame does not have a color table!");
									}
									
									int transparentIndex = ( (( ((bool) (( gce != null )) ) && global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.getField(gce, "hasTransparentColor", 755457067, true)) )) ? (( ((int) (global::haxe.lang.Runtime.getField_f(gce, "transparentIndex", 772773472, true)) ) * ((int) (3) ) )) : (-1) );
									global::haxe.io.Bytes pixels = ((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(frame, "pixels", 212463405, true)) );
									int x = 0;
									int writeCaret = ( (( ( ((int) (global::haxe.lang.Runtime.getField_f(frame, "y", 121, true)) ) * ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(data, "logicalScreenDescriptor", 2032764644, true), "width", 1247983110, true)) ) ) + ((int) (global::haxe.lang.Runtime.getField_f(frame, "x", 120, true)) ) )) * 4 );
									int lineSkip = ( ( (( ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(data, "logicalScreenDescriptor", 2032764644, true), "width", 1247983110, true)) ) - ((int) (global::haxe.lang.Runtime.getField_f(frame, "width", 1247983110, true)) ) )) * 4 ) + 4 );
									global::format.gif.DisposalMethod disposalMethod = ( (( ( frameCaret != frameIndex ) && ( gce != null ) )) ? (((global::format.gif.DisposalMethod) (global::haxe.lang.Runtime.getField(gce, "disposalMethod", 701242674, true)) )) : (global::format.gif.DisposalMethod.NO_ACTION) );
									switch (disposalMethod._hx_index) {
										case 2:
										{
											int _g1 = 0;
											int _g = pixels.length;
											while (( _g1 < _g )) {
												int i = _g1++;
												bytes.b[writeCaret] = ((byte) (0) );
												bytes.b[( writeCaret + 1 )] = ((byte) (0) );
												bytes.b[( writeCaret + 2 )] = ((byte) (0) );
												bytes.b[( writeCaret + 3 )] = ((byte) (0) );
												if ((  ++ x == ((int) (global::haxe.lang.Runtime.getField_f(frame, "width", 1247983110, true)) ) )) {
													x = 0;
													writeCaret += lineSkip;
												}
												else {
													writeCaret += 4;
												}
												
											}
											
											break;
										}
										
										
										case 3:
										{
											break;
										}
										
										
										default:
										{
											int _g11 = 0;
											int _g2 = pixels.length;
											while (( _g11 < _g2 )) {
												int i1 = _g11++;
												int index = ( ((int) (pixels.b[i1]) ) * 3 );
												if (( transparentIndex != index )) {
													bytes.b[writeCaret] = ((byte) (((int) (ct.b[( index + 2 )]) )) );
													bytes.b[( writeCaret + 1 )] = ((byte) (((int) (ct.b[( index + 1 )]) )) );
													bytes.b[( writeCaret + 2 )] = ((byte) (((int) (ct.b[index]) )) );
													bytes.b[( writeCaret + 3 )] = ((byte) (255) );
												}
												
												if ((  ++ x == ((int) (global::haxe.lang.Runtime.getField_f(frame, "width", 1247983110, true)) ) )) {
													x = 0;
													writeCaret += lineSkip;
												}
												else {
													writeCaret += 4;
												}
												
											}
											
											break;
										}
										
									}
									
									if (( frameCaret == frameIndex )) {
										return bytes;
									}
									
									 ++ frameCaret;
									gce = null;
								}
								
								break;
							}
							
							
							case 1:
							{
								global::format.gif.Extension ext = ( block as global::format.gif.Block_BExtension ).extension;
								if (( ext._hx_index == 0 )) {
									object g = ( ext as global::format.gif.Extension_EGraphicControl ).gce;
									gce = g;
								}
								
								break;
							}
							
							
							default:
							{
								break;
							}
							
						}
						
					}
					
				}
				
				return bytes;
			}
		}
		
		
		public static global::haxe.io.Bytes extractFullRGBA(object data, int frameIndex) {
			unchecked {
				object gce = null;
				int frameCaret = 0;
				global::haxe.io.Bytes bytes = global::haxe.io.Bytes.alloc(( ( ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(data, "logicalScreenDescriptor", 2032764644, true), "width", 1247983110, true)) ) * ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(data, "logicalScreenDescriptor", 2032764644, true), "height", 38537191, true)) ) ) * 4 ));
				{
					global::haxe.ds._List.ListNode<object> _g_head = ((global::haxe.ds.List<object>) (global::haxe.ds.List<object>.__hx_cast<object>(((global::haxe.ds.List) (global::haxe.lang.Runtime.getField(data, "blocks", 669658758, true)) ))) ).h;
					while (( _g_head != null )) {
						global::format.gif.Block val = ((global::format.gif.Block) (_g_head.item) );
						_g_head = _g_head.next;
						global::format.gif.Block block = ((global::format.gif.Block) (val) );
						switch (block._hx_index) {
							case 0:
							{
								object frame = ( block as global::format.gif.Block_BFrame ).frame;
								{
									global::haxe.io.Bytes ct = ( (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.getField(frame, "localColorTable", 706588918, true))) ? (((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(frame, "colorTable", 793759659, true)) )) : (((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(data, "globalColorTable", 146652910, true)) )) );
									if (( ct == null )) {
										throw global::haxe.lang.HaxeException.wrap("Frame does not have a color table!");
									}
									
									int transparentIndex = ( (( ((bool) (( gce != null )) ) && global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.getField(gce, "hasTransparentColor", 755457067, true)) )) ? (( ((int) (global::haxe.lang.Runtime.getField_f(gce, "transparentIndex", 772773472, true)) ) * ((int) (3) ) )) : (-1) );
									global::haxe.io.Bytes pixels = ((global::haxe.io.Bytes) (global::haxe.lang.Runtime.getField(frame, "pixels", 212463405, true)) );
									int x = 0;
									int writeCaret = ( (( ( ((int) (global::haxe.lang.Runtime.getField_f(frame, "y", 121, true)) ) * ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(data, "logicalScreenDescriptor", 2032764644, true), "width", 1247983110, true)) ) ) + ((int) (global::haxe.lang.Runtime.getField_f(frame, "x", 120, true)) ) )) * 4 );
									int lineSkip = ( ( (( ((int) (global::haxe.lang.Runtime.getField_f(global::haxe.lang.Runtime.getField(data, "logicalScreenDescriptor", 2032764644, true), "width", 1247983110, true)) ) - ((int) (global::haxe.lang.Runtime.getField_f(frame, "width", 1247983110, true)) ) )) * 4 ) + 4 );
									global::format.gif.DisposalMethod disposalMethod = ( (( ( frameCaret != frameIndex ) && ( gce != null ) )) ? (((global::format.gif.DisposalMethod) (global::haxe.lang.Runtime.getField(gce, "disposalMethod", 701242674, true)) )) : (global::format.gif.DisposalMethod.NO_ACTION) );
									switch (disposalMethod._hx_index) {
										case 2:
										{
											int _g1 = 0;
											int _g = pixels.length;
											while (( _g1 < _g )) {
												int i = _g1++;
												bytes.b[writeCaret] = ((byte) (0) );
												bytes.b[( writeCaret + 1 )] = ((byte) (0) );
												bytes.b[( writeCaret + 2 )] = ((byte) (0) );
												bytes.b[( writeCaret + 3 )] = ((byte) (0) );
												if ((  ++ x == ((int) (global::haxe.lang.Runtime.getField_f(frame, "width", 1247983110, true)) ) )) {
													x = 0;
													writeCaret += lineSkip;
												}
												else {
													writeCaret += 4;
												}
												
											}
											
											break;
										}
										
										
										case 3:
										{
											break;
										}
										
										
										default:
										{
											int _g11 = 0;
											int _g2 = pixels.length;
											while (( _g11 < _g2 )) {
												int i1 = _g11++;
												int index = ( ((int) (pixels.b[i1]) ) * 3 );
												if (( transparentIndex != index )) {
													bytes.b[writeCaret] = ((byte) (((int) (ct.b[index]) )) );
													bytes.b[( writeCaret + 1 )] = ((byte) (((int) (ct.b[( index + 1 )]) )) );
													bytes.b[( writeCaret + 2 )] = ((byte) (((int) (ct.b[( index + 2 )]) )) );
													bytes.b[( writeCaret + 3 )] = ((byte) (255) );
												}
												
												if ((  ++ x == ((int) (global::haxe.lang.Runtime.getField_f(frame, "width", 1247983110, true)) ) )) {
													x = 0;
													writeCaret += lineSkip;
												}
												else {
													writeCaret += 4;
												}
												
											}
											
											break;
										}
										
									}
									
									if (( frameCaret == frameIndex )) {
										return bytes;
									}
									
									 ++ frameCaret;
									gce = null;
								}
								
								break;
							}
							
							
							case 1:
							{
								global::format.gif.Extension ext = ( block as global::format.gif.Block_BExtension ).extension;
								if (( ext._hx_index == 0 )) {
									object g = ( ext as global::format.gif.Extension_EGraphicControl ).gce;
									gce = g;
								}
								
								break;
							}
							
							
							default:
							{
								break;
							}
							
						}
						
					}
					
				}
				
				return bytes;
			}
		}
		
		
		public static int loopCount(object data) {
			unchecked {
				{
					global::haxe.ds._List.ListNode<object> _g_head = ((global::haxe.ds.List<object>) (global::haxe.ds.List<object>.__hx_cast<object>(((global::haxe.ds.List) (global::haxe.lang.Runtime.getField(data, "blocks", 669658758, true)) ))) ).h;
					while (( _g_head != null )) {
						global::format.gif.Block val = ((global::format.gif.Block) (_g_head.item) );
						_g_head = _g_head.next;
						global::format.gif.Block block = ((global::format.gif.Block) (val) );
						if (( block._hx_index == 1 )) {
							if (( ( block as global::format.gif.Block_BExtension ).extension._hx_index == 3 )) {
								if (( ( ( block as global::format.gif.Block_BExtension ).extension as global::format.gif.Extension_EApplicationExtension ).ext._hx_index == 0 )) {
									int loops = ( ( ( block as global::format.gif.Block_BExtension ).extension as global::format.gif.Extension_EApplicationExtension ).ext as global::format.gif.ApplicationExtension_AENetscapeLooping ).loops;
									return loops;
								}
								
							}
							
						}
						
					}
					
				}
				
				return 1;
			}
		}
		
		
		public static double LN2;
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static double log2(double val) {
			return ( global::System.Math.Log(((double) (val) )) / global::format.gif.Tools.LN2 );
		}
		
		
	}
}


