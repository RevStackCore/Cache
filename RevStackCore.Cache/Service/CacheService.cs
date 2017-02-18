using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RevStackCore.Pattern;

namespace RevStackCore.Cache
{
	public class CacheService<TEntity,TKey> : ICacheService<TEntity,TKey> where TEntity: class, IEntity<TKey>
	{
		private readonly ICacheRepository<TEntity,TKey> _repository;
		public CacheService(ICacheRepository<TEntity, TKey> repository)
		{
			_repository = repository;
		}

		public virtual void Delete(string key)
		{
			_repository.Delete(key);
		}

		public virtual Task DeleteAsync(string key)
		{
			return Task.Run(() => Delete(key));
		}

		public virtual TEntity Get(string key)
		{
			return _repository.Get(key);
		}

		public virtual Task<TEntity> GetAsync(string key)
		{
			return Task.FromResult(Get(key));
		}

		public virtual IEnumerable<TEntity> GetCollection(string key)
		{
			return _repository.GetCollection(key);
		}

		public virtual Task<IEnumerable<TEntity>> GetCollectionAsync(string key)
		{
			return Task.FromResult(GetCollection(key));
		}

		public virtual void Set(TEntity entity, string key)
		{
			_repository.Set(entity, key);
		}

		public virtual void Set(TEntity entity, string key, TimeSpan timeSpan)
		{
			_repository.Set(entity, key, timeSpan);
		}

		public virtual Task SetAsync(TEntity entity, string key)
		{
			return Task.Run(() => Set(entity, key));
		}

		public virtual Task SetAsync(TEntity entity, string key, TimeSpan timeSpan)
		{
			return Task.Run(() => Set(entity, key,timeSpan));
		}
	}
}
