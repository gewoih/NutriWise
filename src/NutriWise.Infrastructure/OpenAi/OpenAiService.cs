using System.Text;
using Microsoft.Extensions.Configuration;
using NutriWise.Infrastructure.Extensions;
using OpenAI.Chat;

namespace NutriWise.Infrastructure.OpenAi;

public class OpenAiService
{
	private readonly IConfiguration _configuration;

	public OpenAiService(IConfiguration configuration)
	{
		_configuration = configuration;
	}

	public async Task<string> GetJsonResponse(string jsonSchemaFileName, string promptFileName, string message)
	{
		var client = new ChatClient(model: "gpt-4o", apiKey: _configuration["OpenAi:ApiKey"]);
		var recipeResponseJsonSchema = await EmbeddedResourcesUtils.GetResourceFileContentAsync(jsonSchemaFileName);
			
		var options = new ChatCompletionOptions
		{
			Temperature = 0.5f,
			ResponseFormat = ChatResponseFormat.CreateJsonSchemaFormat(
				jsonSchemaFormatName: "recipes",
				jsonSchema: BinaryData.FromBytes(Encoding.UTF8.GetBytes(recipeResponseJsonSchema)),
				jsonSchemaIsStrict: true)
		};

		var prompt = await EmbeddedResourcesUtils.GetResourceFileContentAsync(promptFileName);
		var completion = await client.CompleteChatAsync([$"{prompt} {message}"], options);
		return completion.Value.Content[0].Text;
	}
}