using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "GetContactRequest")]
	[Serializable]
	public class GetContactRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private uint _UserCount;

		private readonly List<SKBuiltinString_t> _UserNameList = new List<SKBuiltinString_t>();

		private uint _AntispamTicketCount = 0u;

		private readonly List<SKBuiltinString_t> _AntispamTicket = new List<SKBuiltinString_t>();

		private uint _FromChatRoomCount = 0u;

		private readonly List<SKBuiltinString_t> _FromChatRoom = new List<SKBuiltinString_t>();

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseRequest", DataFormat = DataFormat.Default)]
		public BaseRequest BaseRequest
		{
			get
			{
				return this._BaseRequest;
			}
			set
			{
				this._BaseRequest = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "UserCount", DataFormat = DataFormat.TwosComplement)]
		public uint UserCount
		{
			get
			{
				return this._UserCount;
			}
			set
			{
				this._UserCount = value;
			}
		}

		[ProtoMember(3, Name = "UserNameList", DataFormat = DataFormat.Default)]
		public List<SKBuiltinString_t> UserNameList
		{
			get
			{
				return this._UserNameList;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "AntispamTicketCount", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint AntispamTicketCount
		{
			get
			{
				return this._AntispamTicketCount;
			}
			set
			{
				this._AntispamTicketCount = value;
			}
		}

		[ProtoMember(5, Name = "AntispamTicket", DataFormat = DataFormat.Default)]
		public List<SKBuiltinString_t> AntispamTicket
		{
			get
			{
				return this._AntispamTicket;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "FromChatRoomCount", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint FromChatRoomCount
		{
			get
			{
				return this._FromChatRoomCount;
			}
			set
			{
				this._FromChatRoomCount = value;
			}
		}

		[ProtoMember(7, Name = "FromChatRoom", DataFormat = DataFormat.Default)]
		public List<SKBuiltinString_t> FromChatRoom
		{
			get
			{
				return this._FromChatRoom;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
