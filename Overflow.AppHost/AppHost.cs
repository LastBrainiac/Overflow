using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var keycloak = builder.AddKeycloak("keycloak", 6001)
    .WithDataVolume("keycloak-data");

var postgres = builder.AddPostgres("postgres", port:5432)
    .WithDataVolume("postgres-data")
    .WithPgAdmin();

var questiondDb = postgres.AddDatabase("questionDb");

var questionService = builder.AddProject<QuestionService>("question-svc")
    .WithReference(keycloak)
    .WithReference(questiondDb)
    .WaitFor(keycloak)
    .WaitFor(questiondDb);

builder.Build().Run();
