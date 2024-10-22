using System.Reflection;

namespace NutriWise.Infrastructure.Extensions;

public static class EmbeddedResourcesUtils
{
	public static async Task<string> GetResourceFileContentAsync(string fileName)
	{
		var assembly = Assembly.GetExecutingAssembly();
		var resourceNames = assembly.GetManifestResourceNames();
		var resourceName = Array.Find(resourceNames, resource => resource.EndsWith(fileName, StringComparison.OrdinalIgnoreCase));
		await using var stream = assembly.GetManifestResourceStream(resourceName);
		if (stream == null)
			throw new FileNotFoundException("Не удалось найти ресурс: " + fileName);
		
		using var reader = new StreamReader(stream);
		var fileContent = await reader.ReadToEndAsync();
		
		return fileContent;
	}
}