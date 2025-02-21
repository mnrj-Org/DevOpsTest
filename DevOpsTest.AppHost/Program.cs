var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.DevOpsTest_ApiService>("apiservice");

builder.AddProject<Projects.DevOpsTest_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
