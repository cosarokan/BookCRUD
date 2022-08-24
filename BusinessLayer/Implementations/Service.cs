using AutoMapper;
using DataAccessLayer;
namespace BusinessLayer.Implementations
{
    public class Service<TViewModel, TModel, Id> : IService<TViewModel, Id> where TViewModel : class, new() where TModel : class, new()
    {
        private readonly IRepository<TModel, Id> _repository;
        private readonly IMapper _mapper; // +
        private readonly string _includeEntities;

        public Service(IRepository<TModel, Id> repository, IMapper mapper, string includeEntities = null)
        {
            _repository = repository;
            _mapper = mapper;
            _includeEntities = includeEntities;
        }

        public bool Add(TViewModel model)
        {
            try
            {
                TModel tModel = _mapper.Map<TViewModel, TModel>(model);
                bool result = _repository.Add(tModel);
                TViewModel dataModel = _mapper.Map<TModel, TViewModel>(tModel);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Delete(TViewModel model)
        {
            TModel tModel = _mapper.Map<TViewModel, TModel>(model);
            bool result = _repository.Delete(tModel);

            return result;
        }
        public bool Update(TViewModel model)
        {
            try
            {
                TModel tModel = _mapper.Map<TViewModel, TModel>(model);
                bool result = _repository.Update(tModel);

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<TViewModel> GetAll()
        {
            try
            {
                var data = _repository.GetAll();
                List<TViewModel> dataList = _mapper.Map<List<TModel>, List<TViewModel>>(data);

                return dataList;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public TViewModel GetById(Id id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("Id null olamaz");
                }
                var data = _repository.GetById(id);

                if (data == null)
                {
                    throw new Exception("Kayıt bulunamadı");
                }

                var model = _mapper.Map<TModel, TViewModel>(data);

                return model;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
