// Generated by Haxe 4.0.0 (git build development @ 3018ab109)

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public class Block : global::haxe.lang.Enum {
		
		protected Block(int index) : base(index) {
		}
		
		
		public static global::format.gif.Block BFrame(object frame) {
			return new global::format.gif.Block_BFrame(frame);
		}
		
		
		public static global::format.gif.Block BExtension(global::format.gif.Extension extension) {
			return new global::format.gif.Block_BExtension(extension);
		}
		
		
		public static readonly global::format.gif.Block BEOF = new global::format.gif.Block_BEOF();
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class Block_BFrame : global::format.gif.Block {
		
		public Block_BFrame(object frame) : base(0) {
			this.frame = frame;
		}
		
		
		public override global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{this.frame});
		}
		
		
		public override string getTag() {
			return "BFrame";
		}
		
		
		public override int GetHashCode() {
			return global::haxe.lang.Enum.paramsGetHashCode(0, new object[]{this.frame});
		}
		
		
		public override bool Equals(object other) {
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				return true;
			}
			
			global::format.gif.Block_BFrame en = ( other as global::format.gif.Block_BFrame );
			if (( en == null )) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.frame) ), ((object) (en.frame) ))) ) {
				return false;
			}
			
			return true;
		}
		
		
		public override string toString() {
			return global::haxe.lang.Enum.paramsToString("BFrame", new object[]{this.frame});
		}
		
		
		public readonly object frame;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class Block_BExtension : global::format.gif.Block {
		
		public Block_BExtension(global::format.gif.Extension extension) : base(1) {
			this.extension = extension;
		}
		
		
		public override global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{this.extension});
		}
		
		
		public override string getTag() {
			return "BExtension";
		}
		
		
		public override int GetHashCode() {
			unchecked {
				return global::haxe.lang.Enum.paramsGetHashCode(1, new object[]{this.extension});
			}
		}
		
		
		public override bool Equals(object other) {
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				return true;
			}
			
			global::format.gif.Block_BExtension en = ( other as global::format.gif.Block_BExtension );
			if (( en == null )) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.extension) ), ((object) (en.extension) ))) ) {
				return false;
			}
			
			return true;
		}
		
		
		public override string toString() {
			return global::haxe.lang.Enum.paramsToString("BExtension", new object[]{this.extension});
		}
		
		
		public readonly global::format.gif.Extension extension;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class Block_BEOF : global::format.gif.Block {
		
		public Block_BEOF() : base(2) {
		}
		
		
		public override string getTag() {
			return "BEOF";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public class Extension : global::haxe.lang.Enum {
		
		protected Extension(int index) : base(index) {
		}
		
		
		public static global::format.gif.Extension EGraphicControl(object gce) {
			return new global::format.gif.Extension_EGraphicControl(gce);
		}
		
		
		public static global::format.gif.Extension EComment(string text) {
			return new global::format.gif.Extension_EComment(text);
		}
		
		
		public static global::format.gif.Extension EText(object pte) {
			return new global::format.gif.Extension_EText(pte);
		}
		
		
		public static global::format.gif.Extension EApplicationExtension(global::format.gif.ApplicationExtension ext) {
			return new global::format.gif.Extension_EApplicationExtension(ext);
		}
		
		
		public static global::format.gif.Extension EUnknown(int id, global::haxe.io.Bytes data) {
			return new global::format.gif.Extension_EUnknown(id, data);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class Extension_EGraphicControl : global::format.gif.Extension {
		
		public Extension_EGraphicControl(object gce) : base(0) {
			this.gce = gce;
		}
		
		
		public override global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{this.gce});
		}
		
		
		public override string getTag() {
			return "EGraphicControl";
		}
		
		
		public override int GetHashCode() {
			return global::haxe.lang.Enum.paramsGetHashCode(0, new object[]{this.gce});
		}
		
		
		public override bool Equals(object other) {
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				return true;
			}
			
			global::format.gif.Extension_EGraphicControl en = ( other as global::format.gif.Extension_EGraphicControl );
			if (( en == null )) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.gce) ), ((object) (en.gce) ))) ) {
				return false;
			}
			
			return true;
		}
		
		
		public override string toString() {
			return global::haxe.lang.Enum.paramsToString("EGraphicControl", new object[]{this.gce});
		}
		
		
		public readonly object gce;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class Extension_EComment : global::format.gif.Extension {
		
		public Extension_EComment(string text) : base(1) {
			this.text = text;
		}
		
		
		public override global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{this.text});
		}
		
		
		public override string getTag() {
			return "EComment";
		}
		
		
		public override int GetHashCode() {
			unchecked {
				return global::haxe.lang.Enum.paramsGetHashCode(1, new object[]{this.text});
			}
		}
		
		
		public override bool Equals(object other) {
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				return true;
			}
			
			global::format.gif.Extension_EComment en = ( other as global::format.gif.Extension_EComment );
			if (( en == null )) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.text) ), ((object) (en.text) ))) ) {
				return false;
			}
			
			return true;
		}
		
		
		public override string toString() {
			return global::haxe.lang.Enum.paramsToString("EComment", new object[]{this.text});
		}
		
		
		public readonly string text;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class Extension_EText : global::format.gif.Extension {
		
		public Extension_EText(object pte) : base(2) {
			this.pte = pte;
		}
		
		
		public override global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{this.pte});
		}
		
		
		public override string getTag() {
			return "EText";
		}
		
		
		public override int GetHashCode() {
			unchecked {
				return global::haxe.lang.Enum.paramsGetHashCode(2, new object[]{this.pte});
			}
		}
		
		
		public override bool Equals(object other) {
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				return true;
			}
			
			global::format.gif.Extension_EText en = ( other as global::format.gif.Extension_EText );
			if (( en == null )) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.pte) ), ((object) (en.pte) ))) ) {
				return false;
			}
			
			return true;
		}
		
		
		public override string toString() {
			return global::haxe.lang.Enum.paramsToString("EText", new object[]{this.pte});
		}
		
		
		public readonly object pte;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class Extension_EApplicationExtension : global::format.gif.Extension {
		
		public Extension_EApplicationExtension(global::format.gif.ApplicationExtension ext) : base(3) {
			this.ext = ext;
		}
		
		
		public override global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{this.ext});
		}
		
		
		public override string getTag() {
			return "EApplicationExtension";
		}
		
		
		public override int GetHashCode() {
			unchecked {
				return global::haxe.lang.Enum.paramsGetHashCode(3, new object[]{this.ext});
			}
		}
		
		
		public override bool Equals(object other) {
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				return true;
			}
			
			global::format.gif.Extension_EApplicationExtension en = ( other as global::format.gif.Extension_EApplicationExtension );
			if (( en == null )) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.ext) ), ((object) (en.ext) ))) ) {
				return false;
			}
			
			return true;
		}
		
		
		public override string toString() {
			return global::haxe.lang.Enum.paramsToString("EApplicationExtension", new object[]{this.ext});
		}
		
		
		public readonly global::format.gif.ApplicationExtension ext;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class Extension_EUnknown : global::format.gif.Extension {
		
		public Extension_EUnknown(int id, global::haxe.io.Bytes data) : base(4) {
			this.id = id;
			this.data = data;
		}
		
		
		public override global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{this.id, this.data});
		}
		
		
		public override string getTag() {
			return "EUnknown";
		}
		
		
		public override int GetHashCode() {
			unchecked {
				return global::haxe.lang.Enum.paramsGetHashCode(4, new object[]{this.id, this.data});
			}
		}
		
		
		public override bool Equals(object other) {
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				return true;
			}
			
			global::format.gif.Extension_EUnknown en = ( other as global::format.gif.Extension_EUnknown );
			if (( en == null )) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.id) ), ((object) (en.id) ))) ) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.data) ), ((object) (en.data) ))) ) {
				return false;
			}
			
			return true;
		}
		
		
		public override string toString() {
			return global::haxe.lang.Enum.paramsToString("EUnknown", new object[]{this.id, this.data});
		}
		
		
		public readonly int id;
		
		public readonly global::haxe.io.Bytes data;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public class ApplicationExtension : global::haxe.lang.Enum {
		
		protected ApplicationExtension(int index) : base(index) {
		}
		
		
		public static global::format.gif.ApplicationExtension AENetscapeLooping(int loops) {
			return new global::format.gif.ApplicationExtension_AENetscapeLooping(loops);
		}
		
		
		public static global::format.gif.ApplicationExtension AEUnknown(string name, string version, global::haxe.io.Bytes data) {
			return new global::format.gif.ApplicationExtension_AEUnknown(name, version, data);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class ApplicationExtension_AENetscapeLooping : global::format.gif.ApplicationExtension {
		
		public ApplicationExtension_AENetscapeLooping(int loops) : base(0) {
			this.loops = loops;
		}
		
		
		public override global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{this.loops});
		}
		
		
		public override string getTag() {
			return "AENetscapeLooping";
		}
		
		
		public override int GetHashCode() {
			return global::haxe.lang.Enum.paramsGetHashCode(0, new object[]{this.loops});
		}
		
		
		public override bool Equals(object other) {
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				return true;
			}
			
			global::format.gif.ApplicationExtension_AENetscapeLooping en = ( other as global::format.gif.ApplicationExtension_AENetscapeLooping );
			if (( en == null )) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.loops) ), ((object) (en.loops) ))) ) {
				return false;
			}
			
			return true;
		}
		
		
		public override string toString() {
			return global::haxe.lang.Enum.paramsToString("AENetscapeLooping", new object[]{this.loops});
		}
		
		
		public readonly int loops;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class ApplicationExtension_AEUnknown : global::format.gif.ApplicationExtension {
		
		public ApplicationExtension_AEUnknown(string name, string version, global::haxe.io.Bytes data) : base(1) {
			this.name = name;
			this.version = version;
			this.data = data;
		}
		
		
		public override global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{this.name, this.version, this.data});
		}
		
		
		public override string getTag() {
			return "AEUnknown";
		}
		
		
		public override int GetHashCode() {
			unchecked {
				return global::haxe.lang.Enum.paramsGetHashCode(1, new object[]{this.name, this.version, this.data});
			}
		}
		
		
		public override bool Equals(object other) {
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				return true;
			}
			
			global::format.gif.ApplicationExtension_AEUnknown en = ( other as global::format.gif.ApplicationExtension_AEUnknown );
			if (( en == null )) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.name) ), ((object) (en.name) ))) ) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.version) ), ((object) (en.version) ))) ) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.data) ), ((object) (en.data) ))) ) {
				return false;
			}
			
			return true;
		}
		
		
		public override string toString() {
			return global::haxe.lang.Enum.paramsToString("AEUnknown", new object[]{this.name, this.version, this.data});
		}
		
		
		public readonly string name;
		
		public readonly string version;
		
		public readonly global::haxe.io.Bytes data;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public class Version : global::haxe.lang.Enum {
		
		protected Version(int index) : base(index) {
		}
		
		
		public static readonly global::format.gif.Version GIF87a = new global::format.gif.Version_GIF87a();
		
		public static readonly global::format.gif.Version GIF89a = new global::format.gif.Version_GIF89a();
		
		public static global::format.gif.Version Unknown(string version) {
			return new global::format.gif.Version_Unknown(version);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class Version_GIF87a : global::format.gif.Version {
		
		public Version_GIF87a() : base(0) {
		}
		
		
		public override string getTag() {
			return "GIF87a";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class Version_GIF89a : global::format.gif.Version {
		
		public Version_GIF89a() : base(1) {
		}
		
		
		public override string getTag() {
			return "GIF89a";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class Version_Unknown : global::format.gif.Version {
		
		public Version_Unknown(string version) : base(2) {
			this.version = version;
		}
		
		
		public override global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{this.version});
		}
		
		
		public override string getTag() {
			return "Unknown";
		}
		
		
		public override int GetHashCode() {
			unchecked {
				return global::haxe.lang.Enum.paramsGetHashCode(2, new object[]{this.version});
			}
		}
		
		
		public override bool Equals(object other) {
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				return true;
			}
			
			global::format.gif.Version_Unknown en = ( other as global::format.gif.Version_Unknown );
			if (( en == null )) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.version) ), ((object) (en.version) ))) ) {
				return false;
			}
			
			return true;
		}
		
		
		public override string toString() {
			return global::haxe.lang.Enum.paramsToString("Unknown", new object[]{this.version});
		}
		
		
		public readonly string version;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public class DisposalMethod : global::haxe.lang.Enum {
		
		protected DisposalMethod(int index) : base(index) {
		}
		
		
		public static readonly global::format.gif.DisposalMethod UNSPECIFIED = new global::format.gif.DisposalMethod_UNSPECIFIED();
		
		public static readonly global::format.gif.DisposalMethod NO_ACTION = new global::format.gif.DisposalMethod_NO_ACTION();
		
		public static readonly global::format.gif.DisposalMethod FILL_BACKGROUND = new global::format.gif.DisposalMethod_FILL_BACKGROUND();
		
		public static readonly global::format.gif.DisposalMethod RENDER_PREVIOUS = new global::format.gif.DisposalMethod_RENDER_PREVIOUS();
		
		public static global::format.gif.DisposalMethod UNDEFINED(int index) {
			return new global::format.gif.DisposalMethod_UNDEFINED(index);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class DisposalMethod_UNSPECIFIED : global::format.gif.DisposalMethod {
		
		public DisposalMethod_UNSPECIFIED() : base(0) {
		}
		
		
		public override string getTag() {
			return "UNSPECIFIED";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class DisposalMethod_NO_ACTION : global::format.gif.DisposalMethod {
		
		public DisposalMethod_NO_ACTION() : base(1) {
		}
		
		
		public override string getTag() {
			return "NO_ACTION";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class DisposalMethod_FILL_BACKGROUND : global::format.gif.DisposalMethod {
		
		public DisposalMethod_FILL_BACKGROUND() : base(2) {
		}
		
		
		public override string getTag() {
			return "FILL_BACKGROUND";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class DisposalMethod_RENDER_PREVIOUS : global::format.gif.DisposalMethod {
		
		public DisposalMethod_RENDER_PREVIOUS() : base(3) {
		}
		
		
		public override string getTag() {
			return "RENDER_PREVIOUS";
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace format.gif {
	public sealed class DisposalMethod_UNDEFINED : global::format.gif.DisposalMethod {
		
		public DisposalMethod_UNDEFINED(int index) : base(4) {
			this.index = index;
		}
		
		
		public override global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{this.index});
		}
		
		
		public override string getTag() {
			return "UNDEFINED";
		}
		
		
		public override int GetHashCode() {
			unchecked {
				return global::haxe.lang.Enum.paramsGetHashCode(4, new object[]{this.index});
			}
		}
		
		
		public override bool Equals(object other) {
			if (global::System.Object.ReferenceEquals(((object) (this) ), ((object) (other) ))) {
				return true;
			}
			
			global::format.gif.DisposalMethod_UNDEFINED en = ( other as global::format.gif.DisposalMethod_UNDEFINED );
			if (( en == null )) {
				return false;
			}
			
			if ( ! (global::haxe.root.Type.enumEq<object>(((object) (this.index) ), ((object) (en.index) ))) ) {
				return false;
			}
			
			return true;
		}
		
		
		public override string toString() {
			return global::haxe.lang.Enum.paramsToString("UNDEFINED", new object[]{this.index});
		}
		
		
		public readonly int index;
		
	}
}


