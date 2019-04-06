﻿namespace Team3_Project.Databases.type {
	public class Boolean : abstraction {
		private static readonly System.Converter<abstraction , Boolean> converter;
		public static readonly Boolean self;
		static Boolean() {
			converter = (abstraction item) => (Boolean) item;
			self = new Boolean();
		}
		public System.Boolean value;
		public Boolean() {
			this.value = false;
		}
		public Boolean(System.Boolean value) {
			this.value = value;
		}
		public override System.Boolean Equals(System.Object Object) {
			return this.value.Equals(Object);
		}
		public override System.Int32 GetHashCode() {
			return this.value.GetHashCode();
		}
		public override void cast(System.Object Object) {
			this.value = System.Convert.ToBoolean(Object);
		}
		public override System.Boolean parse(System.String text) {
			return System.Boolean.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}