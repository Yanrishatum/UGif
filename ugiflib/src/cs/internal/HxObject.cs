// Generated by Haxe 4.0.0 (git build development @ 3018ab109)

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public interface IHxObject {
		
		bool __hx_deleteField(string field, int hash);
		
		object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck);
		
		double __hx_lookupField_f(string field, int hash, bool throwErrors);
		
		object __hx_lookupSetField(string field, int hash, object @value);
		
		double __hx_lookupSetField_f(string field, int hash, double @value);
		
		double __hx_setField_f(string field, int hash, double @value, bool handleProperties);
		
		object __hx_setField(string field, int hash, object @value, bool handleProperties);
		
		object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties);
		
		double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties);
		
		object __hx_invokeField(string field, int hash, object[] dynargs);
		
		void __hx_getFields(global::haxe.root.Array<object> baseArr);
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class HxObject : global::haxe.lang.IHxObject {
		
		public HxObject(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public HxObject() {
			global::haxe.lang.HxObject.__hx_ctor_haxe_lang_HxObject(this);
		}
		
		
		protected static void __hx_ctor_haxe_lang_HxObject(global::haxe.lang.HxObject __hx_this) {
		}
		
		
		public virtual bool __hx_deleteField(string field, int hash) {
			return false;
		}
		
		
		public virtual object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck) {
			if (isCheck) {
				return global::haxe.lang.Runtime.undefined;
			}
			else if (throwErrors) {
				throw new global::System.MemberAccessException("Field not found.");
			}
			else {
				return null;
			}
			
		}
		
		
		public virtual double __hx_lookupField_f(string field, int hash, bool throwErrors) {
			if (throwErrors) {
				throw new global::System.MemberAccessException("Field not found or incompatible field type.");
			}
			else {
				return default(double);
			}
			
		}
		
		
		public virtual object __hx_lookupSetField(string field, int hash, object @value) {
			throw new global::System.MemberAccessException("Cannot access field for writing.");
		}
		
		
		public virtual double __hx_lookupSetField_f(string field, int hash, double @value) {
			throw new global::System.MemberAccessException("Cannot access field for writing or incompatible type.");
		}
		
		
		public virtual double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			switch (hash) {
				default:
				{
					return this.__hx_lookupSetField_f(field, hash, @value);
				}
				
			}
			
		}
		
		
		public virtual object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			switch (hash) {
				default:
				{
					return this.__hx_lookupSetField(field, hash, @value);
				}
				
			}
			
		}
		
		
		public virtual object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			switch (hash) {
				default:
				{
					return this.__hx_lookupField(field, hash, throwErrors, isCheck);
				}
				
			}
			
		}
		
		
		public virtual double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			switch (hash) {
				default:
				{
					return this.__hx_lookupField_f(field, hash, throwErrors);
				}
				
			}
			
		}
		
		
		public virtual object __hx_invokeField(string field, int hash, object[] dynargs) {
			switch (hash) {
				default:
				{
					return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
				}
				
			}
			
		}
		
		
		public virtual void __hx_getFields(global::haxe.root.Array<object> baseArr) {
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class DynamicObject : global::haxe.lang.HxObject {
		
		public DynamicObject(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public DynamicObject() {
			global::haxe.lang.DynamicObject.__hx_ctor_haxe_lang_DynamicObject(((global::haxe.lang.DynamicObject) (this) ));
		}
		
		
		public DynamicObject(int[] __hx_hashes, object[] __hx_dynamics, int[] __hx_hashes_f, double[] __hx_dynamics_f) {
			global::haxe.lang.DynamicObject.__hx_ctor_haxe_lang_DynamicObject(((global::haxe.lang.DynamicObject) (this) ), ((int[]) (__hx_hashes) ), ((object[]) (__hx_dynamics) ), ((int[]) (__hx_hashes_f) ), ((double[]) (__hx_dynamics_f) ));
		}
		
		
		protected static void __hx_ctor_haxe_lang_DynamicObject(global::haxe.lang.DynamicObject __hx_this) {
			__hx_this.__hx_hashes = new int[]{};
			__hx_this.__hx_dynamics = new object[]{};
			__hx_this.__hx_hashes_f = new int[]{};
			__hx_this.__hx_dynamics_f = new double[]{};
		}
		
		
		protected static void __hx_ctor_haxe_lang_DynamicObject(global::haxe.lang.DynamicObject __hx_this, int[] __hx_hashes, object[] __hx_dynamics, int[] __hx_hashes_f, double[] __hx_dynamics_f) {
			__hx_this.__hx_hashes = __hx_hashes;
			__hx_this.__hx_dynamics = __hx_dynamics;
			__hx_this.__hx_hashes_f = __hx_hashes_f;
			__hx_this.__hx_dynamics_f = __hx_dynamics_f;
			__hx_this.__hx_length = __hx_hashes.Length;
			__hx_this.__hx_length_f = __hx_hashes_f.Length;
		}
		
		
		public virtual string toString() {
			global::haxe.lang.Function ts = ((global::haxe.lang.Function) (global::haxe.lang.Runtime.getField(this, "toString", 946786476, false)) );
			if (( ts != null )) {
				return global::haxe.lang.Runtime.toString(ts.__hx_invoke0_o());
			}
			
			global::System.Text.StringBuilder ret_b = new global::System.Text.StringBuilder();
			ret_b.Append(((string) ("{") ));
			bool first = true;
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = global::haxe.root.Reflect.fields(this);
				while (( _g < _g1.length )) {
					string f = global::haxe.lang.Runtime.toString(_g1[_g]);
					 ++ _g;
					if (first) {
						first = false;
					}
					else {
						ret_b.Append(((string) (",") ));
					}
					
					ret_b.Append(((string) (" ") ));
					ret_b.Append(((string) (global::haxe.root.Std.@string(f)) ));
					ret_b.Append(((string) (" : ") ));
					ret_b.Append(((string) (global::haxe.root.Std.@string(((object) (global::haxe.root.Reflect.field(this, f)) ))) ));
				}
				
			}
			
			if ( ! (first) ) {
				ret_b.Append(((string) (" ") ));
			}
			
			ret_b.Append(((string) ("}") ));
			return ret_b.ToString();
		}
		
		
		public global::haxe.lang.FieldHashConflict __hx_conflicts;
		
		public int[] __hx_hashes;
		
		public object[] __hx_dynamics;
		
		public int[] __hx_hashes_f;
		
		public double[] __hx_dynamics_f;
		
		public int __hx_length;
		
		public int __hx_length_f;
		
		public override bool __hx_deleteField(string field, int hash) {
			if (( hash < 0 )) {
				return global::haxe.lang.FieldLookup.deleteHashConflict(ref this.__hx_conflicts, hash, field);
			}
			
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
			if (( res >= 0 )) {
				global::haxe.lang.FieldLookup.@remove<int>(((int[]) (this.__hx_hashes) ), ((int) (this.__hx_length) ), ((int) (res) ));
				global::haxe.lang.FieldLookup.@remove<object>(((object[]) (this.__hx_dynamics) ), ((int) (this.__hx_length) ), ((int) (res) ));
				this.__hx_length--;
				return true;
			}
			else {
				res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
				if (( res >= 0 )) {
					global::haxe.lang.FieldLookup.@remove<int>(((int[]) (this.__hx_hashes_f) ), ((int) (this.__hx_length_f) ), ((int) (res) ));
					global::haxe.lang.FieldLookup.@remove<double>(((double[]) (this.__hx_dynamics_f) ), ((int) (this.__hx_length_f) ), ((int) (res) ));
					this.__hx_length_f--;
					return true;
				}
				
			}
			
			return false;
		}
		
		
		public override object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck) {
			if (( hash < 0 )) {
				global::haxe.lang.FieldHashConflict conflict = global::haxe.lang.FieldLookup.getHashConflict(this.__hx_conflicts, hash, field);
				if (( conflict != null )) {
					return conflict.@value;
				}
				
			}
			else {
				int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
				if (( res >= 0 )) {
					return this.__hx_dynamics[res];
				}
				else {
					res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
					if (( res >= 0 )) {
						return this.__hx_dynamics_f[res];
					}
					
				}
				
			}
			
			if (isCheck) {
				return global::haxe.lang.Runtime.undefined;
			}
			else {
				return null;
			}
			
		}
		
		
		public override double __hx_lookupField_f(string field, int hash, bool throwErrors) {
			if (( hash < 0 )) {
				global::haxe.lang.FieldHashConflict conflict = global::haxe.lang.FieldLookup.getHashConflict(this.__hx_conflicts, hash, field);
				if (( conflict != null )) {
					return ((double) (global::haxe.lang.Runtime.toDouble(conflict.@value)) );
				}
				
			}
			else {
				int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
				if (( res >= 0 )) {
					return this.__hx_dynamics_f[res];
				}
				else {
					res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
					if (( res >= 0 )) {
						return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_dynamics[res])) );
					}
					
				}
				
			}
			
			return default(double);
		}
		
		
		public override object __hx_lookupSetField(string field, int hash, object @value) {
			if (( hash < 0 )) {
				global::haxe.lang.FieldLookup.setHashConflict(ref this.__hx_conflicts, hash, field, @value);
			}
			else {
				int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
				if (( res >= 0 )) {
					return this.__hx_dynamics[res] = @value;
				}
				else {
					int res2 = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
					if (( res2 >= 0 )) {
						global::haxe.lang.FieldLookup.@remove<int>(((int[]) (this.__hx_hashes_f) ), ((int) (this.__hx_length_f) ), ((int) (res2) ));
						global::haxe.lang.FieldLookup.@remove<double>(((double[]) (this.__hx_dynamics_f) ), ((int) (this.__hx_length_f) ), ((int) (res2) ));
						this.__hx_length_f--;
					}
					
				}
				
				global::haxe.lang.FieldLookup.insert<int>(ref this.__hx_hashes, ((int) (this.__hx_length) ), ((int) ( ~ (res) ) ), ((int) (hash) ));
				global::haxe.lang.FieldLookup.insert<object>(ref this.__hx_dynamics, ((int) (this.__hx_length) ), ((int) ( ~ (res) ) ), ((object) (@value) ));
				this.__hx_length++;
			}
			
			return @value;
		}
		
		
		public override double __hx_lookupSetField_f(string field, int hash, double @value) {
			if (( hash < 0 )) {
				global::haxe.lang.FieldLookup.setHashConflict(ref this.__hx_conflicts, hash, field, @value);
			}
			else {
				int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
				if (( res >= 0 )) {
					return this.__hx_dynamics_f[res] = @value;
				}
				else {
					int res2 = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
					if (( res2 >= 0 )) {
						global::haxe.lang.FieldLookup.@remove<int>(((int[]) (this.__hx_hashes) ), ((int) (this.__hx_length) ), ((int) (res2) ));
						global::haxe.lang.FieldLookup.@remove<object>(((object[]) (this.__hx_dynamics) ), ((int) (this.__hx_length) ), ((int) (res2) ));
						this.__hx_length--;
					}
					
				}
				
				global::haxe.lang.FieldLookup.insert<int>(ref this.__hx_hashes_f, ((int) (this.__hx_length_f) ), ((int) ( ~ (res) ) ), ((int) (hash) ));
				global::haxe.lang.FieldLookup.insert<double>(ref this.__hx_dynamics_f, ((int) (this.__hx_length_f) ), ((int) ( ~ (res) ) ), ((double) (@value) ));
				this.__hx_length_f++;
			}
			
			return @value;
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<object> baseArr) {
			int i = default(int);
			i = 0;
			while (( i < this.__hx_length )) {
				baseArr.push(global::haxe.lang.FieldLookup.lookupHash(this.__hx_hashes[i++]));
			}
			
			i = 0;
			while (( i < this.__hx_length_f )) {
				baseArr.push(global::haxe.lang.FieldLookup.lookupHash(this.__hx_hashes_f[i++]));
			}
			
			global::haxe.lang.FieldLookup.addHashConflictNames(this.__hx_conflicts, baseArr);
			base.__hx_getFields(baseArr);
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public interface IGenericObject : global::haxe.lang.IHxObject {
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class GenericInterface : global::System.Attribute {
		
		public GenericInterface(global::System.Type generic) : base() {
			this.generic = generic;
		}
		
		
		public readonly global::System.Type generic;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class Enum {
		
		protected Enum(int index) {
			this._hx_index = index;
		}
		
		
		protected static string paramsToString(string tag, object[] @params) {
			global::System.Text.StringBuilder ret_b = new global::System.Text.StringBuilder();
			ret_b.Append(((string) (global::haxe.root.Std.@string(tag)) ));
			ret_b.Append(((string) ("(") ));
			bool first = true;
			{
				int _g = 0;
				while (( _g < ( ((object[]) (@params) ) as global::System.Array ).Length )) {
					object p = ((object) (((object[]) (@params) )[_g]) );
					 ++ _g;
					if (first) {
						first = false;
					}
					else {
						ret_b.Append(((string) (",") ));
					}
					
					ret_b.Append(((string) (global::haxe.root.Std.@string(((object) (p) ))) ));
				}
				
			}
			
			ret_b.Append(((string) (")") ));
			return ret_b.ToString();
		}
		
		
		protected static int paramsGetHashCode(int index, object[] @params) {
			unchecked {
				int h = 19;
				if (( @params != null )) {
					int _g = 0;
					while (( _g < ( ((object[]) (@params) ) as global::System.Array ).Length )) {
						object p = ((object) (((object[]) (@params) )[_g]) );
						 ++ _g;
						h *= 31;
						if (( p != null )) {
							h += ((int) (global::haxe.lang.Runtime.toInt(p.GetHashCode())) );
						}
						
					}
					
				}
				
				h += index;
				return h;
			}
		}
		
		
		public readonly int _hx_index;
		
		public virtual string getTag() {
			throw global::haxe.lang.HaxeException.wrap("Not Implemented");
		}
		
		
		public virtual global::haxe.root.Array<object> getParams() {
			return new global::haxe.root.Array<object>(new object[]{});
		}
		
		
		public virtual string toString() {
			return this.getTag();
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}


