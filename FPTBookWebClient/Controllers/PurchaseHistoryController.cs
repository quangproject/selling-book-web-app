﻿using BusinessObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;

namespace FPTBookWebClient.Controllers
{
	[Authorize(Roles = "User")]
	public class PurchaseHistoryController : Controller
	{
		private readonly IConfiguration _configuration;
		private readonly UserManager<AppUser> _userManager;

		private readonly HttpClient client = null;
		private string api;

		public PurchaseHistoryController(UserManager<AppUser> userManager, IConfiguration configuration)
		{
			_configuration = configuration;
			client = new HttpClient();
			client.BaseAddress = new Uri(_configuration["BaseAddress"]);
			var contentType = new MediaTypeWithQualityHeaderValue("application/json");
			client.DefaultRequestHeaders.Accept.Add(contentType);
			this.api = "/api/Orders";

			_userManager = userManager;
		}

		public async Task<IActionResult> Index()
		{
			string userId = _userManager.GetUserId(User);
			HttpResponseMessage httpResponse = await client.GetAsync(api + "/User/" + userId);
			string data = await httpResponse.Content.ReadAsStringAsync();
			var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
			List<Order> orders = JsonSerializer.Deserialize<List<Order>>(data, options);
			return View(orders);
		}
	}
}
