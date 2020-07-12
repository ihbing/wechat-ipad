using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "SendAppMsgRequest")]
	[Serializable]
	public class SendAppMsgRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private AppMsg _Msg;

		private string _CommentUrl = "";

		private uint _ReqTime = 0u;

		private string _Md5 = "";

		private uint _FileType = 0u;

		private string _Signature = "";

		private string _FromSence = "";

		private uint _HitMd5 = 0u;

		private uint _CRC32 = 0u;

		private uint _MsgForwardType = 0u;

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

		[ProtoMember(2, IsRequired = true, Name = "Msg", DataFormat = DataFormat.Default)]
		public AppMsg Msg
		{
			get
			{
				return this._Msg;
			}
			set
			{
				this._Msg = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "CommentUrl", DataFormat = DataFormat.Default), DefaultValue("")]
		public string CommentUrl
		{
			get
			{
				return this._CommentUrl;
			}
			set
			{
				this._CommentUrl = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "ReqTime", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
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

		[ProtoMember(5, IsRequired = false, Name = "Md5", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Md5
		{
			get
			{
				return this._Md5;
			}
			set
			{
				this._Md5 = value;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "FileType", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint FileType
		{
			get
			{
				return this._FileType;
			}
			set
			{
				this._FileType = value;
			}
		}

		[ProtoMember(7, IsRequired = false, Name = "Signature", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Signature
		{
			get
			{
				return this._Signature;
			}
			set
			{
				this._Signature = value;
			}
		}

		[ProtoMember(8, IsRequired = false, Name = "FromSence", DataFormat = DataFormat.Default), DefaultValue("")]
		public string FromSence
		{
			get
			{
				return this._FromSence;
			}
			set
			{
				this._FromSence = value;
			}
		}

		[ProtoMember(9, IsRequired = false, Name = "HitMd5", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint HitMd5
		{
			get
			{
				return this._HitMd5;
			}
			set
			{
				this._HitMd5 = value;
			}
		}

		[ProtoMember(10, IsRequired = false, Name = "CRC32", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint CRC32
		{
			get
			{
				return this._CRC32;
			}
			set
			{
				this._CRC32 = value;
			}
		}

		[ProtoMember(11, IsRequired = false, Name = "MsgForwardType", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint MsgForwardType
		{
			get
			{
				return this._MsgForwardType;
			}
			set
			{
				this._MsgForwardType = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
