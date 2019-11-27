using System.Collections.Generic;
namespace ApplicationCore.Interfaces
{
    public interface IService<Entity, Dto, SaveDto>
    {
         Dto toDto(Entity entity);
        IEnumerable<Dto> toDtoRange(IEnumerable<Entity> entities);

        Entity toEntity(SaveDto save);
        void convertEntityToDto(Entity entity, Dto dto);
        void convertDtoToEntity(SaveDto dto, Entity entity);
    }
}