using Classes.Canal;
using Data.Resources.Interfaces;
using Microsoft.AspNetCore.SignalR;
using ProjetoCare.Utils.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Utils.ReceiverSgnR
{
	public class Chat : Hub
	{
		private readonly ICanal cn;
		public Chat(ICanal cn)	
		{
			this.cn = cn;
		}

		/// <summary>
		/// Envio de mensagens instantaneas por chat
		/// </summary>
		/// <param name="channel">id do canal</param>
		/// <param name="user">nome do usuario</param>
		/// <param name="message">mensagem</param>
		/// <returns>envia a mensagem para o canal selecionado</returns>
		public async Task SendMessage(string channel, string user, string message)
		{
			await Clients.All.SendAsync("ReceiveMessage", user, message);

			await cn.Add(new CanalUser()
			{ 
				CanalId = int.Parse(channel),
				Mensagem = message,
				Nome = user
			});

		}
	}
}
