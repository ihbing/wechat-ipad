using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "InviteFriend")]
	[Serializable]
	public class InviteFriend : IExtensible
	{
		private uint _Uin;

		private SKBuiltinString_t _NickName;

		private string _Email = "";

		private string _Remark = "";

		private string _UserName = "";

		private uint _FriendType = 0u;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Uin", DataFormat = DataFormat.TwosComplement)]
		public uint Uin
		{
			get
			{
				return this._Uin;
			}
			set
			{
				this._Uin = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "NickName", DataFormat = DataFormat.Default)]
		public SKBuiltinString_t NickName
		{
			get
			{
				return this._NickName;
			}
			set
			{
				this._NickName = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "Email", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				this._Email = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "Remark", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Remark
		{
			get
			{
				return this._Remark;
			}
			set
			{
				this._Remark = value;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "UserName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				this._UserName = value;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "FriendType", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint FriendType
		{
			get
			{
				return this._FriendType;
			}
			set
			{
				this._FriendType = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
