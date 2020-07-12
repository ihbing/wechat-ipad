using ProtoBuf;
using System;
using System.Collections.Generic;

namespace BlockDumpList
{
	[ProtoContract(Name = "BlockDumpList")]
	[Serializable]
	public class BlockDumpList : IExtensible
	{
		private readonly List<byte[]> _BlockDump = new List<byte[]>();

		private IExtension extensionObject;

		[ProtoMember(1, Name = "BlockDump", DataFormat = DataFormat.Default)]
		public List<byte[]> BlockDump
		{
			get
			{
				return this._BlockDump;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
