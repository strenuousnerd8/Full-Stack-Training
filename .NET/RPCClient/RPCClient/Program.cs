using RPCClientEx;

Console.WriteLine("Hello, World!");

var rpcClient = new RpcClient();

Console.WriteLine("[x] Requesting fib(10)");
var response = rpcClient.Call("3");

Console.WriteLine("[.] Got {0}", response);
rpcClient.Close();

