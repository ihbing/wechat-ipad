using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "EmojiUploadRequest")]
	[Serializable]
	public class EmojiUploadRequest : IExtensible
	{
		private readonly List<UploadEmojiInfoReq> _EmojiItem = new List<UploadEmojiInfoReq>();

		private uint _ReqTime = 0u;

		private IExtension extensionObject;

		[ProtoMember(1, Name = "EmojiItem", DataFormat = DataFormat.Default)]
		public List<UploadEmojiInfoReq> EmojiItem
		{
			get
			{
				return this._EmojiItem;
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "ReqTime", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint ReqTime
		{
			get
			{
				return this._ReqTime;
			}
			set
			{
				this._ReqTime = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
