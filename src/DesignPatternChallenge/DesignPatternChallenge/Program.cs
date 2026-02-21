using DesignPatternChallenge.Core;
using DesignPatternChallenge.Services;

Console.WriteLine("=== Sistema de Configurações (Singleton) ===\n");

Console.WriteLine("Inicializando serviços...\n");

var dbService = new DatabaseService();
var apiService = new ApiService();
var cacheService = new CacheService();
var logService = new LoggingService();

Console.WriteLine("\nUsando os serviços...\n");

dbService.Connect();
apiService.MakeRequest();
cacheService.Connect();
logService.Log("Sistema iniciado");

Console.WriteLine("\n--- Atualização Global de Configuração ---\n");

// Pegando a mesma instância única
var config = ConfigurationManager.Instance;
config.UpdateSetting("LogLevel", "Debug");

// Pegando novamente a instância (é a mesma!)
var config2 = ConfigurationManager.Instance;

Console.WriteLine($"Config1 LogLevel: {config.GetSetting("LogLevel")}");
Console.WriteLine($"Config2 LogLevel: {config2.GetSetting("LogLevel")}");

Console.WriteLine("\n✔ Agora não há inconsistência!");
Console.WriteLine("✔ Apenas uma instância existe em toda aplicação!");
Console.WriteLine("✔ Configurações compartilhadas globalmente!");

Console.ReadKey();