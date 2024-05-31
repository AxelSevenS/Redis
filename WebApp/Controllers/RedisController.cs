namespace ProjectMana.Controllers;

using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;

[ApiController]
[Route("api")]
public class RedisController(IConnectionMultiplexer redis) : ControllerBase
{
	[HttpGet]
	public IActionResult GetRedisContent()
	{
		try
		{
			IDatabase db = redis.GetDatabase();
			IServer server = redis.GetServer(redis.GetEndPoints().First());

			string[] keys = server.Keys(pattern: "*").Select(k => k.ToString()).ToArray();
			Dictionary<string, string> content = [];
			foreach (string key in keys)
			{
				string? value = db.StringGet(key);;
				if (value is not null) {
					content[key] = value;
				}
			}

			return Ok(content);
		}
		catch (Exception ex)
		{
			// Log the exception
			Console.WriteLine($"Error fetching data from Redis: {ex.Message}");
			return StatusCode(500, "Internal server error");
		}
	}

	[HttpPost]
	public async Task<IActionResult> PostRedisContent([FromForm] Dictionary<string, string> data)
	{
		IDatabase db = redis.GetDatabase();
		long entryId = await db.StringIncrementAsync("entryIdCounter");
		string serializedData = JsonSerializer.Serialize(data);
		await db.StringSetAsync($"entry:{entryId}", serializedData);

		return Ok($"Data Entry added successfully : {serializedData}");
	}
}