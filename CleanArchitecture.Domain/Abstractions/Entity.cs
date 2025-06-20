﻿namespace CleanArchitecture.Domain.Abstractions;
public class Entity
{
    public Entity()
    {
        Id= Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdateDate { get; set; }

}
