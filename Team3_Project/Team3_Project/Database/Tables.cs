﻿namespace Team3_Project.Database {
	public class Tables {
		public readonly System.String schema;
		public readonly System.String table;
		public readonly System.String column;
		public readonly System.String select;
		public readonly System.String insert;
		public Tables(System.String schema , System.String table , System.String[] column) {
			this.schema = System.String.Concat("`", schema, "`");
			this.table = System.String.Concat(this.schema , ".`" , table, "`");
			System.Int32 index = column.Length;
			System.String[] result = new System.String[index];
			while (index > 0) {
				index -= 1;
				result[index] = System.String.Concat(this.table , ".`" , column[index] , "`");
			}
			this.column = System.String.Join(", " , result);
			this.select = System.String.Concat(new System.String[] {
				"SELECT ",
				this.column,
				" FROM ",
				this.table
			});
			this.insert = System.String.Concat(new System.String[] {
				"INSERT INTO ",
				this.table,
				" (",
				this.column,
				")"
			});
		}
		private System.String limit(System.UInt32? limit = null) {
			return limit == null ? System.String.Empty : System.String.Concat(" LIMIT " , limit);
		}
		private System.String where(System.String where = "") {
			return System.String.IsNullOrEmpty(where) ? System.String.Empty : System.String.Concat(" WHERE " , where);
		}
		public System.String SELECT(System.String where = "" , System.UInt32? limit = null) {
			return System.String.Concat(this.select , this.where(where) , this.limit(limit) , ';');
		}
		public System.String INSERT(root data ) {
			System.String values = System.String.Join(", " , data.values());
			return System.String.Concat(this.insert, " VALUES (", values, ");");
		}

	}
}