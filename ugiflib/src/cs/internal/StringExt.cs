// Generated by Haxe 4.0.0 (git build development @ 3018ab109)

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class StringExt {
		
		public StringExt() {
		}
		
		
		public static readonly global::System.String empty = new global::System.String(((char) (0) ), 0);
		
		public static global::System.String charAt(global::System.String me, int index) {
			unchecked {
				if (((bool) (( ((uint) (index) ) >= me.Length )) )) {
					return global::haxe.lang.StringExt.empty;
				}
				else {
					return new global::System.String(me[index], 1);
				}
				
			}
		}
		
		
		public static global::haxe.lang.Null<int> charCodeAt(global::System.String me, int index) {
			if (((bool) (( ((uint) (index) ) >= me.Length )) )) {
				return default(global::haxe.lang.Null<int>);
			}
			else {
				return new global::haxe.lang.Null<int>(((int) (me[index]) ), true);
			}
			
		}
		
		
		public static int indexOf(global::System.String me, string str, global::haxe.lang.Null<int> startIndex) {
			unchecked {
				int sIndex = ( (startIndex.hasValue) ? ((startIndex).@value) : (0) );
				if (( sIndex >= me.Length )) {
					return -1;
				}
				
				return me.IndexOf(((string) (str) ), ((int) (sIndex) ), ((global::System.StringComparison) (global::System.StringComparison.Ordinal) ));
			}
		}
		
		
		public static int lastIndexOf(global::System.String me, global::System.String str, global::haxe.lang.Null<int> startIndex) {
			unchecked {
				int sIndex = ( ( ! (startIndex.hasValue) ) ? (( me.Length - 1 )) : ((startIndex).@value) );
				if (( sIndex >= me.Length )) {
					sIndex = ( me.Length - 1 );
				}
				else if (( sIndex < 0 )) {
					return -1;
				}
				
				if (startIndex.hasValue) {
					int i = ( sIndex + 1 );
					while (( i-- > 0 )) {
						bool found = true;
						{
							int _g1 = 0;
							int _g = str.Length;
							while (( _g1 < _g )) {
								int j = _g1++;
								if (( me[( i + j )] != str[j] )) {
									found = false;
									break;
								}
								
							}
							
						}
						
						if (found) {
							return i;
						}
						
					}
					
					return -1;
				}
				else {
					return me.LastIndexOf(((string) (str) ), ((int) (sIndex) ), ((global::System.StringComparison) (global::System.StringComparison.Ordinal) ));
				}
				
			}
		}
		
		
		public static global::haxe.root.Array<object> split(global::System.String me, global::System.String delimiter) {
			unchecked {
				string[] native = null;
				if (( delimiter.Length == 0 )) {
					int len = me.Length;
					native = new string[len];
					{
						int _g1 = 0;
						int _g = len;
						while (( _g1 < _g )) {
							int i = _g1++;
							native[i] = new global::System.String(me[i], 1);
						}
						
					}
					
				}
				else {
					string[] str = new string[1];
					str[0] = global::haxe.lang.Runtime.toString(delimiter);
					native = me.Split(((string[]) (str) ), ((global::System.StringSplitOptions) (global::System.StringSplitOptions.None) ));
				}
				
				return new global::haxe.root.Array<object>(((object[]) (native) ));
			}
		}
		
		
		public static string substr(global::System.String me, int pos, global::haxe.lang.Null<int> len) {
			int meLen = me.Length;
			int targetLen = meLen;
			if (len.hasValue) {
				targetLen = (len).@value;
				if (( ( targetLen == 0 ) || ( ( pos != 0 ) && ( targetLen < 0 ) ) )) {
					return "";
				}
				
			}
			
			if (( pos < 0 )) {
				pos = ( meLen + pos );
				if (( pos < 0 )) {
					pos = 0;
				}
				
			}
			else if (( targetLen < 0 )) {
				targetLen = ( ( meLen + targetLen ) - pos );
			}
			
			if (( ( pos + targetLen ) > meLen )) {
				targetLen = ( meLen - pos );
			}
			
			if (( ( pos < 0 ) || ( targetLen <= 0 ) )) {
				return "";
			}
			
			return me.Substring(((int) (pos) ), ((int) (targetLen) ));
		}
		
		
		public static string substring(global::System.String me, int startIndex, global::haxe.lang.Null<int> endIndex) {
			int len = me.Length;
			int endIdx = default(int);
			if ( ! (endIndex.hasValue) ) {
				endIdx = len;
			}
			else {
				endIdx = (endIndex).@value;
				if (( endIdx < 0 )) {
					endIdx = 0;
				}
				else if (( endIdx > len )) {
					endIdx = len;
				}
				
			}
			
			if (( startIndex < 0 )) {
				startIndex = 0;
			}
			else if (( startIndex > len )) {
				startIndex = len;
			}
			
			if (( startIndex > endIdx )) {
				int tmp = startIndex;
				startIndex = endIdx;
				endIdx = tmp;
			}
			
			return me.Substring(((int) (startIndex) ), ((int) (( endIdx - startIndex )) ));
		}
		
		
		public static global::System.String toString(global::System.String me) {
			return me;
		}
		
		
		public static string toLowerCase(global::System.String me) {
			return me.ToLowerInvariant();
		}
		
		
		public static string toUpperCase(global::System.String me) {
			return me.ToUpperInvariant();
		}
		
		
		public static global::System.String toNativeString(global::System.String me) {
			return me;
		}
		
		
		public static global::System.String fromCharCode(int code) {
			unchecked {
				return new global::System.String(((char) (code) ), 1);
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class StringRefl {
		
		static StringRefl() {
			global::haxe.lang.StringRefl.fields = new global::haxe.root.Array<object>(new object[]{"length", "toUpperCase", "toLowerCase", "charAt", "charCodeAt", "indexOf", "lastIndexOf", "split", "substr", "substring"});
		}
		
		
		public StringRefl() {
		}
		
		
		public static global::haxe.root.Array<object> fields;
		
		public static object handleGetField(string str, string f, bool throwErrors) {
			switch (f) {
				case "length":
				{
					return str.Length;
				}
				
				
				case "charAt":
				case "charCodeAt":
				case "indexOf":
				case "lastIndexOf":
				case "split":
				case "substr":
				case "substring":
				case "toLowerCase":
				case "toUpperCase":
				{
					return new global::haxe.lang.Closure(str, f, 0);
				}
				
				
				default:
				{
					if (throwErrors) {
						throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Field not found: \'", f), "\' in String"));
					}
					else {
						return null;
					}
					
				}
				
			}
			
		}
		
		
		public static object handleCallField(global::System.String str, string f, object[] args) {
			unchecked {
				object[] _args = null;
				if (( args == null )) {
					_args = new global::System.String[]{((global::System.String) (str) )};
				}
				else {
					_args = new object[( ( args as global::System.Array ).Length + 1 )];
					{
						int _g1 = 0;
						int _g = ( args as global::System.Array ).Length;
						while (( _g1 < _g )) {
							int i = _g1++;
							_args[( i + 1 )] = args[i];
						}
						
					}
					
					_args[0] = str;
				}
				
				return global::haxe.lang.Runtime.slowCallField(typeof(global::haxe.lang.StringExt), f, _args);
			}
		}
		
		
	}
}


