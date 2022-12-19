using RPCClientEx;

Console.WriteLine("Hello, World!");

var rpcClient = new RpcClient();

Console.Write("Enter nth integer of the fibonacci:\t");
string? n = Console.ReadLine();

Console.WriteLine($"[x] Requesting fib({n})");
var response = rpcClient.Call(n);

Console.WriteLine("[.] Got {0}", response);
rpcClient.Close();

