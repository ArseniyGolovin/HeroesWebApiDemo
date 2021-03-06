# HeroesWebApiDemo
ASP.NET Core Web API demo with integration test sample project using .NET 6.

Application functionality:
1) Implemented basic demo REST CRUD API controller using CQRS pattern (HeroesController)
2) Authentication logic using JWT bearer tokens (IdentityController/IdentityService)
3) Swagger service which is used for testing APIs
4) ORM Entity Framework Core is used to work with ApplicationDbContext
5) Integration tests using xUnit
6) Dtos validation using FluentValidation
7) Caching requests using redis (off by default, activated in appsettings.json, RedisCacheSetting.Enabled flag)

Design patterns used:
1) Repository
2) Data transfer objects (Dtos)
3) CQRS
4) Mediator

Other NuGet packages used:
1) AutoMapper
2) FluentAssertions
3) JetBrains.Annotations
4) MediatR
