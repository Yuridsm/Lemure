using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Lemure.JWT;

public class DecoteJWTClient
{
    public static void Run()
    {
        var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjEwMDAwMCIsInByb2ZpbGVzIjoiQnJva2VyIiwidXNlcl9pZGVudGlmaWVyIjoiMjU0ZjQ1ZmMtYmJlNy00YzljLWEyZDgtNjkwZWYyNGVkYjczIiwibmFtZSI6IkNvcnJldG9yIDEwMDAwMCIsInByb2ZpbGVzX2lkZW50aWZpZXJzIjoiW1wiYnI6NmRhNjJjMzMtYzNmNy00NGY3LWFmMDUtZjdmNjEwNmVkNzg4XCJdIiwicGFyZW50X25hbWUiOiJDb3JyZXRvcmEgMTAwMDAwIiwicGFyZW50c19pZGVudGlmaWVycyI6IltcImJrOjlhYzlmNmZlLTVhMjUtNGNlZS1iYWVhLWFjODY4MjIyZTM4MlwiXSIsIm5iZiI6MTcwNTYxNTkxNCwiZXhwIjoxNzA2MjIwNzE0LCJpYXQiOjE3MDU2MTU5MTQsImlzcyI6IkZGIiwiYXVkIjoiRkZBUEkifQ.H_Ho8IbcSstMUTMT7aTMPRuAhRzj6_pJIXYsz6CqP1c";
        var handler = new JwtSecurityTokenHandler();
        var jsonToken = handler.ReadToken(token);
        var tokens = jsonToken as JwtSecurityToken;

        // Console.WriteLine(tokens);

        if (tokens is null) return;

        var claims = tokens.Claims;

        if (tokens is null) return;

        foreach (var property in claims)
        {
            Console.WriteLine($"{property.Type} : {property.Value}");
        }
    }
}
