# Entity Framework Reference

# Summary

- [. . /Frameworks](../frameworks.md)
- [DbContext](#dbcontext)
- [Entity Tracking](#tracking-and-no-tracking)


# DbContext
> Source: https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/
>   
> Article: https://martinfowler.com/eaaCatalog/unitOfWork.html

The lifetime of a DbContext begins when the instance is created and ends when the instance is disposed. A DbContext instance is designed to be used for a single unit-of-work. This means that the lifetime of a DbContext instance is usually very short.

The DbContext are not thread-safe.

DbContext in dependency injection for ASP.NET Core, you can configure like this in ``Startup.cs`` or with some changes in ``Program.cs``:
```cs
public void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();

    services.AddDbContext<ApplicationDbContext>(
        options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
}
```

The ApplicationDbContext class must expose a public constructor with a DbContextOptions<ApplicationDbContext> parameter. This is how context configuration from AddDbContext is passed to the DbContext. For example:
```cs
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {}
}
```

So now you can use ``DbContext`` through DI in construtor or [FromServices]. The final result is an ApplicationDbContext instance created for each request and passed to the controller to perform a unit-of-work before being disposed when the request ends.

OnConfiguring can be used to perform additional configuration even when AddDbContext is being used



# Tracking and No-Tracking
> Source: [Tracking vs. No-Tracking Queries](https://learn.microsoft.com/en-us/ef/core/querying/tracking)

Tracking behavior controls if Entity Framework Core keeps information about an entity instance in its change tracker. If an entity is tracked, any changes detected in the entity are persisted to the database during ``SaveChanges()`` method call. EF Core also fixes up navigation properties between the entities in a tracking query result and the entities that are in the change tracker. 
  
**Tracking:** By default, queries that return entity types (e.g. models that have keys) are tracked and we can add or attach entities to the context.
```cs
var blog = context.Blogs.SingleOrDefault(b => b.BlogId == 1);
blog.Rating = 5;
context.SaveChanges();
```

**No-Tracking:** No-tracking queries are useful when the results are used in a read-only scenario. They're generally quicker to execute because there's no need to set up the change tracking information. If the entities retrieved from the database don't need to be updated, then a no-tracking query should be used.
```cs
var blogs = context.Blogs
    .AsNoTracking()
    .ToList();
```

The default tracking behavior can be changed at the context instance level:
```cs
context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

var blogs = context.Blogs.ToList();
```

**Identity resolution:** In some cases, ``AsNoTracking`` is less efficient than tracking default behavior. For an existent entity in the current context, when you do a query and return many entities that are already tracked an ``AsNoTracking`` query will create all new instances from entities returned by the query even if it exists so that using more memory and being less efficient.

To improve memory and performance you should return existent the new materialized entities from query (is created a stand-alone change tracker so that each entity is materialized once, since this change tracker are different from the one in the context, the result are not tracked by the context), so you could use:
```cs
var blogs = context.Blogs
    .AsNoTrackingWithIdentityResolution()
    .ToList();
```

For a default behavior:
```cs
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder
        .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFQuerying.Tracking;Trusted_Connection=True")
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
}
```

**Tracking and custom projections:** Even if the result type of the query isn't an entity type, EF Core will still track entity types contained in the result by default. In the following query, which returns an anonymous type, the instances of Blog in the result set will be tracked.
```cs
var blog = context.Blogs
    .Select(
        b =>
            new { Blog = b, PostCount = b.Posts.Count() });
            //'b' is a blog entity that will be tracked
```

If the result set contains entity types coming out from LINQ composition, EF Core will track them.
```cs
var blog = context.Blogs
    .Select(
        b =>
            new { Blog = b, Post = b.Posts.OrderBy(p => p.Rating).LastOrDefault() });
            //'Blog=b' and if 'Post=b.Posts...' be a database entity will be tracked
```

If the result set doesn't contain any entity types, then no tracking is done.
```cs
var blog = context.Blogs
    .Select(
        b =>
            new { Id = b.BlogId, b.Url });
```

EF Core supports doing client evaluation in the top-level projection. If EF Core materializes an entity instance for client evaluation, it will be tracked.
```cs
var blogs = context.Blogs
    .OrderByDescending(blog => blog.Rating)
    .Select(
                            //this method need a materialized blog instance that will be tracked
        blog => new { Id = blog.BlogId, Url = StandardizeUrl(blog) })
    .ToList();
```