using System;
using System.Collections.Generic;
using System.Net;
using CRS.Helpers;

namespace CRS.PacketProcessing.Messages.Server
{
	// Token: 0x0200008E RID: 142
	internal class RoyalTvContentMessage : Message
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x0001A622 File Offset: 0x00018822
		public RoyalTvContentMessage(Device client, byte Arena)
			: base(client)
		{
			base.SetMessageType(24405);
			this.m_vArena = Arena;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0001A640 File Offset: 0x00018840
		public override void Encode()
		{
			List<byte> list = new List<byte>();

			/*
			string text = new WebClient().DownloadString("http://cdn.gobelinland.fr/royaletv/battles").Trim();
			list.Add(1);
			list.AddString(text);
			list.AddRange(Helpers.Helpers.HexaToBytes("0002821A05A3AF09AB0A01929D0A8902010C000000001477E65E36"));
			list.Add(this.m_vArena);
			list.AddRange(Helpers.Helpers.HexaToBytes("0002821A05A3AF09AB0A01929D0A8902010C000000001477E65E360800000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"));
			*/

			list.Add(1);
			list.AddString("GobelinLand");
			list.AddRange(Helpers.Helpers.HexaToBytes("0002821A05A3AF09AB0A01929D0A8902010C000000001477E65E36"));
			list.Add(this.m_vArena);
			list.AddRange(Helpers.Helpers.HexaToBytes("0002821A05A3AF09AB0A01929D0A8902010C000000001477E65E360800000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"));

			base.Encrypt(list.ToArray());
		}

		// Token: 0x040002DB RID: 731
		public byte m_vArena;
	}
}
