﻿using CommandPattern.Domain.Entities;
using CommandPattern.Domain.Repositories;
using CommandPattern.Domain.Services;

namespace CommandPattern.Api.Services
{
    public class ServiceBase<T, TRepo> : IEntityServiceBase<T>
        where T : EntityBase
        where TRepo : IRepositoryBase<T>
    {
        protected IRepositoryBase<T> Repo { get; }

        public ServiceBase(IRepositoryBase<T> repo)
        {
            Repo = repo;
        }

        public virtual T Add(T entity)
        {
            try
            {
                return Repo.Add(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual bool Delete(T entity)
        {
            try
            {
                return Repo.Delete(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual bool DeleteById(long entityId)
        {
            try
            {
                return Repo.DeleteById(entityId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            try
            {
                return Repo.Filter(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            try
            {
                return Repo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual T? GetById(long id)
        {
            try
            {
                return Repo.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual T Update(T entity)
        {
            try
            {
                return Repo.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
