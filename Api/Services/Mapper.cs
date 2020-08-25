using Api.Models;
using AutoMapper;

namespace Api.Services
{
    public class Mapper<TEntity> where TEntity : EntityBase
    {
        private readonly Mapper _mapper;

        public Mapper()
        {
            var mapperConfig = new MapperConfiguration(config => config.CreateMap<TEntity, TEntity>());
            _mapper = new Mapper(mapperConfig);
        }

        public TEntity Map(TEntity source, TEntity target)
        {
            return _mapper.Map(source, target);
        }
    }
}