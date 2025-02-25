using Microsoft.Extensions.AI;

// docker run -d -v ollama:/root/.ollama -p 11434:11434 --name ollama ollama/ollama
// docker exec -it ollama ollama pull llama3.1
// docker exec -it ollama ollama list
IChatClient client = 
    new OllamaChatClient(new Uri("http://localhost:11434/"), "llama3.1");

var response = await client.GetResponseAsync("What is AI?");

Console.WriteLine(response.Message);