// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.10.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Avro.Test.Specific.@return
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;

	public partial class ComplexTypeWithReservedWords : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ComplexTypeWithReservedWords"",""namespace"":""Avro.Test.Specific.return"",""fields"":[{""name"":""Record"",""type"":{""type"":""record"",""name"":""Record"",""namespace"":""Avro.Test.Specific.return"",""fields"":[{""name"":""name"",""type"":""string""}]}},{""name"":""ArrayItems"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""ArrayItem"",""namespace"":""Avro.Test.Specific.return"",""fields"":[{""name"":""id"",""type"":""long""},{""name"":""name"",""type"":""string""}]}}}]}");
		private Avro.Test.Specific.@return.Record _Record;
		private IList<Avro.Test.Specific.@return.ArrayItem> _ArrayItems;
		public virtual Schema Schema
		{
			get
			{
				return ComplexTypeWithReservedWords._SCHEMA;
			}
		}
		public Avro.Test.Specific.@return.Record Record
		{
			get
			{
				return this._Record;
			}
			set
			{
				this._Record = value;
			}
		}
		public IList<Avro.Test.Specific.@return.ArrayItem> ArrayItems
		{
			get
			{
				return this._ArrayItems;
			}
			set
			{
				this._ArrayItems = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.Record;
			case 1: return this.ArrayItems;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.Record = (Avro.Test.Specific.@return.Record)fieldValue; break;
			case 1: this.ArrayItems = (IList<Avro.Test.Specific.@return.ArrayItem>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}