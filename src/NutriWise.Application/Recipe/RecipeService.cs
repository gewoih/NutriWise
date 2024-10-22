using OpenAI.Chat;

namespace NutriWise.Application.Recipe;

public class RecipeService
{
	public async Task Get()
	{
		var client = new ChatClient(model: "gpt-4o",
			apiKey: "sk-_yOw5Fck2dVKdK3A9Iu8a5Lus--2iC39FhJder3K_kT3BlbkFJ66JYI-ZbqeF6kht8IVrpzgqrjueJ9cDbRA3LwGR3cA");
		
		var chatCompletionOptions = new ChatCompletionOptions
		{
			ResponseFormat = ChatResponseFormat.CreateJsonSchemaFormat(
				jsonSchemaFormatName: "recipes",
				jsonSchema: BinaryData.FromBytes("""
				                                 {
				                                   "type": "object",
				                                   "properties": {
				                                     "meals": {
				                                       "type": "array",
				                                       "items": {
				                                         "type": "object",
				                                         "properties": {
				                                           "name": {
				                                             "type": "string"
				                                           },
				                                           "recipe": {
				                                             "type": "object",
				                                             "properties": {
				                                               "ingredients": {
				                                                 "type": "array",
				                                                 "items": {
				                                                   "type": "object",
				                                                   "properties": {
				                                                     "name": {
				                                                       "type": "string"
				                                                     },
				                                                     "quantity": {
				                                                       "type": "string"
				                                                     }
				                                                   },
				                                                   "required": ["name", "quantity"]
				                                                 }
				                                               },
				                                               "instructions": {
				                                                 "type": "string"
				                                               },
				                                               "macronutrients": {
				                                                 "type": "object",
				                                                 "properties": {
				                                                   "calories": {
				                                                     "type": "number"
				                                                   },
				                                                   "protein": {
				                                                     "type": "number"
				                                                   },
				                                                   "fat": {
				                                                     "type": "number"
				                                                   },
				                                                   "carbs": {
				                                                     "type": "number"
				                                                   }
				                                                 },
				                                                 "required": ["calories", "protein", "fat", "carbs"]
				                                               }
				                                             },
				                                             "required": ["ingredients", "instructions", "macronutrients"]
				                                           }
				                                         },
				                                         "required": ["name", "recipe"]
				                                       }
				                                     }
				                                   },
				                                   "required": ["meals"]
				                                 }
				                                 """u8.ToArray()),
				jsonSchemaIsStrict: true)
		};
		
		
		var completion = await client.CompleteChatAsync([ "generate me recipes with total calories = 1978.625" ], chatCompletionOptions);
	}
}