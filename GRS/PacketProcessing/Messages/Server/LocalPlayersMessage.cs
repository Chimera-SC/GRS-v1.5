using System;
using System.Collections.Generic;
using CRS.Helpers;

namespace CRS.PacketProcessing.Messages.Server
{
	// Token: 0x02000071 RID: 113
	internal class LocalPlayersMessage : Message
	{
		// Token: 0x06000353 RID: 851 RVA: 0x00018C61 File Offset: 0x00016E61
		public LocalPlayersMessage(Device client)
			: base(client)
		{
			base.SetMessageType(24404);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00018C78 File Offset: 0x00016E78
		public override void Encode()
		{
			List<byte> list = new List<byte>();
			list.AddRange(Message.AddVInt(1));
			list.AddRange(Message.AddVInt(1));
			list.AddRange(Message.AddVInt(1));
			list.AddString("Berkan");
			list.AddRange(Message.AddVInt(1));
			list.AddRange(Message.AddVInt(5000));
			list.AddRange(Message.AddVInt(1));
			list.AddRange(Message.AddVInt(0));
			list.AddRange(Message.AddVInt(0));
			list.AddRange(Message.AddVInt(0));
			list.AddRange(Message.AddVInt(12));
			list.AddRange(Message.AddVInt(1));
			list.AddString("GobelinLand");
			base.Encrypt(list.ToArray());
		}
	}
}
