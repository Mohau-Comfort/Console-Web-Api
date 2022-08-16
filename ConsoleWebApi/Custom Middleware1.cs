﻿namespace ConsoleWebApi
{
    public class Custom_Middleware1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from File 1 \n");

            await next(context);

            await context.Response.WriteAsync("Hello from File 2 \n");
        }
    }
}
