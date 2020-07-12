using ProtoBuf;
using System;

namespace micromsg
{
	[ProtoContract(Name = "GetFavInfoResponse")]
	[Serializable]
	public class GetFavInfoResponse : IExtensible
	{
		private BaseResponse _BaseResponse;

		private ulong _UsedSize;

		private ulong _TotalSize;

		private uint _MxFavFileSize;

		private uint _MxAutoUploadSize;

		private uint _MxAutoDownloadSize;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseResponse", DataFormat = DataFormat.Default)]
		public BaseResponse BaseResponse
		{
			get
			{
				return this._BaseResponse;
			}
			set
			{
				this._BaseResponse = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "UsedSize", DataFormat = DataFormat.TwosComplement)]
		public ulong UsedSize
		{
			get
			{
				return this._UsedSize;
			}
			set
			{
				this._UsedSize = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "TotalSize", DataFormat = DataFormat.TwosComplement)]
		public ulong TotalSize
		{
			get
			{
				return this._TotalSize;
			}
			set
			{
				this._TotalSize = value;
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "MxFavFileSize", DataFormat = DataFormat.TwosComplement)]
		public uint MxFavFileSize
		{
			get
			{
				return this._MxFavFileSize;
			}
			set
			{
				this._MxFavFileSize = value;
			}
		}

		[ProtoMember(5, IsRequired = true, Name = "MxAutoUploadSize", DataFormat = DataFormat.TwosComplement)]
		public uint MxAutoUploadSize
		{
			get
			{
				return this._MxAutoUploadSize;
			}
			set
			{
				this._MxAutoUploadSize = value;
			}
		}

		[ProtoMember(6, IsRequired = true, Name = "MxAutoDownloadSize", DataFormat = DataFormat.TwosComplement)]
		public uint MxAutoDownloadSize
		{
			get
			{
				return this._MxAutoDownloadSize;
			}
			set
			{
				this._MxAutoDownloadSize = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
