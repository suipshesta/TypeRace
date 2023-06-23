using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TypeRace.Models;

namespace TypeRace.Hubs
{
	public class GameDetails
	{
		public string gamename { get; set; }
		public string connectionId { get; set; }
		public string playername { get; set; }
	}

	public static class ConnectionCollection
	{
		public static Dictionary<string, List<string>> Connection = new Dictionary<string, List<string>>();
	}
	public static class ConnectionsList
	{
		public static List<string> Connections = new List<string>();
	}
	public static class ConnectionRecord
	{
		public static Dictionary<string, string> UserRecord = new Dictionary<string, string>();
	}
	public static class ActiveUsers
	{
		public static List<GameDetails> Users = new List<GameDetails>();
	}

	public class RaceHub : Hub
	{


		public async Task SendMessage(string user, string message)
		{
			await Clients.All.SendAsync("ReceiveMessage", user, message);
		}
		public async void Announce(string message)
		{
			await Clients.All.SendAsync("Getmessage", message);
		}
		public async void MoveCar(string carname, float velocity, string game)
		{
			await Clients.Group(game).SendAsync("Getspeed", carname, velocity);
			//await Clients.All.SendAsync("Getspeed", carname, velocity);
		}
		public async void AnnounceWinner(string winner, string game, float cpm)
		{
			await Clients.Group(game).SendAsync("Saywinner", winner, cpm);
		}
		public async void MakeReady(string game)
		{
			await Clients.Group(game).SendAsync("StartCountDown");
			GameVar.OnAirGame.Add(game);
		}
		public async void SendMessageToUser(string connectionId, string message)
		{
			await Clients.Client(connectionId).SendAsync("ReceiveMessage", message);
		}
		public int GetTotalUserNo(string gamename)
		{
			var thisgrpUser = ActiveUsers.Users.Where(x => x.gamename == gamename);
			return thisgrpUser.Count();
		}

		public async Task Joingame(GameDetails gamedetails)
		{
			try
			{

				ConnectionRecord.UserRecord.Add(gamedetails.connectionId, gamedetails.gamename);
				ActiveUsers.Users.Add(gamedetails);
				var thisgrpUser = ActiveUsers.Users.Where(x => x.gamename == gamedetails.gamename);
				await Groups.AddToGroupAsync(gamedetails.connectionId, gamedetails.gamename);
				await Clients.Group(gamedetails.gamename).SendAsync("UserConnectedOnGroup", thisgrpUser);
			}
			catch (Exception ex)
			{
				await Clients.Group(gamedetails.gamename).SendAsync("ThrowError", ex.Message.ToString());
			}



		}

		public Task SendMessageToGroup(string game, string message)
		{
			return Clients.Group(game).SendAsync("ReceiveMessage", message);
		}
		public override async Task OnDisconnectedAsync(Exception ex)
		{

			string gamename = ConnectionRecord.UserRecord[Context.ConnectionId];
			try
			{
				ConnectionRecord.UserRecord.Remove(Context.ConnectionId);
				var temp = ActiveUsers.Users.Where(x => x.connectionId == Context.ConnectionId).FirstOrDefault();
				ActiveUsers.Users.Remove(temp);
				//ActiveUsers.Users.Remove(new GameDetails() { connectionId = Context.ConnectionId });
				await Clients.Group(gamename).SendAsync("UserDisconnected", temp);
				var cntingm = ActiveUsers.Users.Where(x => x.gamename == gamename);
				if (cntingm.Count() < 1)
				{
					GameVar.OnAirGame.Remove(gamename);
				}
				//await Clients.All.SendAsync("UserDisconnected", ActiveUsers.Users);
				//await base.OnDisconnectedAsync(ex);
			}
			catch (Exception er)
			{
				await Clients.Group(gamename).SendAsync("ThrowError", er.Message.ToString());
			}
		}

		public string GetConnectionId()
		{
			return Context.ConnectionId;
		}

	}

	public class ConnectionHub : Hub
	{
		public IHubContext<ConnectionHub> Hubcontext { get; }
		public ConnectionHub(IHubContext<ConnectionHub> hubcontext)
		{
			Hubcontext = hubcontext;

		}

		public async Task ThrowUploadComplete(string userId, string fileId)
		{
			await Hubcontext.Clients.Client(userId).SendAsync("ReceiveCompleteMessage", fileId);
		}

		public string GetConnectionId()
		{
			return Context.ConnectionId;
		}
	}
}