namespace VehicleAPI.Core.Entities;

public abstract class Entity : IEntity
{
   public Guid Id { get; set; }
}
