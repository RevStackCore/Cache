using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RevStackCore.Pattern;

namespace RevStackCore.Cache
{
	public interface ICacheService<TEntity,TKey> where TEntity : class, IEntity<TKey>
	{
		IEnumerable<TEntity> GetCollection(string key);
		TEntity Get(string key);
		void Set(TEntity entity, string key);
		void Set(TEntity entity, string key, TimeSpan timeSpan);
		void Delete(string key);
		Task<IEnumerable<TEntity>> GetCollectionAsync(string key);
		Task<TEntity> GetAsync(string key);
		Task SetAsync(TEntity entity, string key);
		Task SetAsync(TEntity entity, string key, TimeSpan timeSpan);
		Task DeleteAsync(string key);
	}
}
