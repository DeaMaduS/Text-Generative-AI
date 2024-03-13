using OpenAI_API;

var key = new APIAuthentication("YOUR KEY");

var api = new OpenAIAPI(key);
var prompt = "A long time ago, in a galaxy far, far away...";
var request = new OpenAI_API.Completions.CompletionRequest(prompt, model: OpenAI_API.Models.Model.Davinci, max_tokens: 100, temperature: 0.7);
var response = await api.Completions.CreateCompletionAsync(request);
var completion = response.Completions[0].Text;
Console.WriteLine("Generated Text: {0}", completion);