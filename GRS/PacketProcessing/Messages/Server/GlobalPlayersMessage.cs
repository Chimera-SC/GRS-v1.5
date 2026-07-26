using System;
using System.Collections.Generic;

namespace CRS.PacketProcessing.Messages.Server
{
	// Token: 0x02000072 RID: 114
	internal class GlobalPlayersMessage : Message
	{
		// Token: 0x06000355 RID: 853 RVA: 0x00018D36 File Offset: 0x00016F36
		public GlobalPlayersMessage(Device client)
			: base(client)
		{
			base.SetMessageType(24403);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00018D4C File Offset: 0x00016F4C
		public override void Encode()
		{
			List<byte> list = new List<byte>();
			list.AddRange(Message.AddVInt(0));
			list.AddRange(Message.AddVInt((int)TimeSpan.FromDays(1.0).TotalSeconds));
			base.Encrypt(list.ToArray());
		}
	}
}
