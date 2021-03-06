// Generated by Haxe 4.0.0 (git build development @ 3018ab109)
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io {
	public class Output : global::haxe.lang.HxObject {
		
		public Output(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Output() {
			global::haxe.io.Output.__hx_ctor_haxe_io_Output(this);
		}
		
		
		protected static void __hx_ctor_haxe_io_Output(global::haxe.io.Output __hx_this) {
		}
		
		
		public bool bigEndian;
		
		public virtual void writeByte(int c) {
			throw global::haxe.lang.HaxeException.wrap("Not implemented");
		}
		
		
		public virtual int writeBytes(global::haxe.io.Bytes s, int pos, int len) {
			if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > s.length ) )) {
				throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
			}
			
			byte[] b = s.b;
			int k = len;
			while (( k > 0 )) {
				this.writeByte(((int) (b[pos]) ));
				 ++ pos;
				 -- k;
			}
			
			return len;
		}
		
		
		public virtual void flush() {
		}
		
		
		public virtual void close() {
		}
		
		
		public virtual bool set_bigEndian(bool b) {
			this.bigEndian = b;
			return b;
		}
		
		
		public virtual void write(global::haxe.io.Bytes s) {
			int l = s.length;
			int p = 0;
			while (( l > 0 )) {
				int k = this.writeBytes(s, p, l);
				if (( k == 0 )) {
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Blocked);
				}
				
				p += k;
				l -= k;
			}
			
		}
		
		
		public virtual void writeFullBytes(global::haxe.io.Bytes s, int pos, int len) {
			while (( len > 0 )) {
				int k = this.writeBytes(s, pos, len);
				pos += k;
				len -= k;
			}
			
		}
		
		
		public virtual void writeUInt16(int x) {
			unchecked {
				if (( ( x < 0 ) || ( x >= 65536 ) )) {
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Overflow);
				}
				
				if (this.bigEndian) {
					this.writeByte(( x >> 8 ));
					this.writeByte(( x & 255 ));
				}
				else {
					this.writeByte(( x & 255 ));
					this.writeByte(( x >> 8 ));
				}
				
			}
		}
		
		
		public virtual void writeInt32(int x) {
			unchecked {
				if (this.bigEndian) {
					this.writeByte(((int) (( ((uint) (x) ) >> 24 )) ));
					this.writeByte(( ( x >> 16 ) & 255 ));
					this.writeByte(( ( x >> 8 ) & 255 ));
					this.writeByte(( x & 255 ));
				}
				else {
					this.writeByte(( x & 255 ));
					this.writeByte(( ( x >> 8 ) & 255 ));
					this.writeByte(( ( x >> 16 ) & 255 ));
					this.writeByte(((int) (( ((uint) (x) ) >> 24 )) ));
				}
				
			}
		}
		
		
		public virtual void writeString(string s) {
			global::haxe.io.Bytes b = global::haxe.io.Bytes.ofString(s);
			this.writeFullBytes(b, 0, b.length);
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 542823803:
					{
						if (handleProperties) {
							this.set_bigEndian(global::haxe.lang.Runtime.toBool(@value));
							return @value;
						}
						else {
							this.bigEndian = global::haxe.lang.Runtime.toBool(@value);
							return @value;
						}
						
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 640252688:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeString", 640252688)) );
					}
					
					
					case 1390579183:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeInt32", 1390579183)) );
					}
					
					
					case 772311838:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeUInt16", 772311838)) );
					}
					
					
					case 610723709:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeFullBytes", 610723709)) );
					}
					
					
					case 1348037855:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "write", 1348037855)) );
					}
					
					
					case 650414942:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_bigEndian", 650414942)) );
					}
					
					
					case 1214453688:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "close", 1214453688)) );
					}
					
					
					case 43737796:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "flush", 43737796)) );
					}
					
					
					case 1381630732:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeBytes", 1381630732)) );
					}
					
					
					case 1238832007:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "writeByte", 1238832007)) );
					}
					
					
					case 542823803:
					{
						return this.bigEndian;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				switch (hash) {
					case 640252688:
					{
						this.writeString(global::haxe.lang.Runtime.toString(dynargs[0]));
						break;
					}
					
					
					case 1390579183:
					{
						this.writeInt32(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 772311838:
					{
						this.writeUInt16(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 610723709:
					{
						this.writeFullBytes(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						break;
					}
					
					
					case 1348037855:
					{
						this.write(((global::haxe.io.Bytes) (dynargs[0]) ));
						break;
					}
					
					
					case 650414942:
					{
						return this.set_bigEndian(global::haxe.lang.Runtime.toBool(dynargs[0]));
					}
					
					
					case 1214453688:
					{
						this.close();
						break;
					}
					
					
					case 43737796:
					{
						this.flush();
						break;
					}
					
					
					case 1381630732:
					{
						return this.writeBytes(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
					}
					
					
					case 1238832007:
					{
						this.writeByte(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return null;
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<object> baseArr) {
			baseArr.push("bigEndian");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


