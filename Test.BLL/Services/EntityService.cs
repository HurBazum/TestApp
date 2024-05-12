using Test.Interfaces;

namespace Test.BLL.Services
{
    public class EntityService<T>(IRepository<T> repository) : IEntityService<T> where T : class, IEntity, new()
    {
        readonly IRepository<T> _repository = repository;

        public async Task<IResponse<T>> Add(T entity)
        {
            var response = new BaseResponse<T>();

            try
            {
                await _repository.Add(entity);
            }
            catch(Exception ex)
            {
                response.Message = ex.InnerException!.Message ?? "Какая-то ошибка";
            }

            return response;
        }

        public async Task<IResponse<T>> Delete(int id)
        {
            var response = new BaseResponse<T>();

            try
            {
                var entity = await _repository.GetById(id) ?? throw new Exception("Элемент с таким id отсутствует");
                await _repository.Delete(id);
                response.Results.Add(entity);
            }
            catch(Exception ex)
            {
                response.Message = ex.InnerException!.Message ?? "Какая-то ошибка";
            }

            return response;
        }

        public async Task<IResponse<T>> GetAll()
        {
            var response = new BaseResponse<T>();

            try
            {
                var entities = await _repository.GetAll() ?? throw new Exception("Нет элементов");
                foreach (var entity in entities)
                {
                    response.Results.Add(entity);
                }
            }
            catch(Exception ex)
            {
                response.Message = ex.InnerException!.Message ?? "Какая-то ошибка";
            }

            return response;
        }

        public async Task<IResponse<T>> GetById(int id)
        {
            var response = new BaseResponse<T>();

            try
            {
                var entity = await _repository.GetById(id) ?? throw new Exception("Элемент с таким id отсутствует");
                response.Results.Add(entity);
            }
            catch(Exception ex)
            {
                response.Message = ex.InnerException!.Message ?? "Какая-то ошибка";
            }

            return response;
        }

        public async Task<IResponse<T>> Update(T entity)
        {
            var response = new BaseResponse<T>();
            
            try
            {
                await _repository.Update(entity);
                response.Results.Add(entity);
            }
            catch(Exception ex)
            {
                response.Message = ex.InnerException!.Message ?? "Какая-то ошибка";
            }

            return response;
        }
    }
}