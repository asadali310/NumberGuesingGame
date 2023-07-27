using Webapiapplication;
namespace Webapiapplication.Controllers;

public static class EmployeeController
{
    public static void MapEmployeeEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Employee", () =>
        {
            return new [] { new Employee() };
        })
        .WithName("GetAllEmployees")
        .Produces<Employee[]>(StatusCodes.Status200OK);

        routes.MapGet("/api/Employee/{id}", (int id) =>
        {
            //return new Employee { ID = id };
        })
        .WithName("GetEmployeeById")
        .Produces<Employee>(StatusCodes.Status200OK);

        routes.MapPut("/api/Employee/{id}", (int id, Employee input) =>
        {
            return Results.NoContent();
        })
        .WithName("UpdateEmployee")
        .Produces(StatusCodes.Status204NoContent);

        routes.MapPost("/api/Employee/", (Employee model) =>
        {
            //return Results.Created($"/api/Employees/{model.ID}", model);
        })
        .WithName("CreateEmployee")
        .Produces<Employee>(StatusCodes.Status201Created);

        routes.MapDelete("/api/Employee/{id}", (int id) =>
        {
            //return Results.Ok(new Employee { ID = id });
        })
        .WithName("DeleteEmployee")
        .Produces<Employee>(StatusCodes.Status200OK);
    }
}
