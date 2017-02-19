using System;
using System.Collections.Generic;
using RevStackCore.Pattern;
namespace RevStackCore.Cache
{
	public interface ICacheRepository<TEntity,TKey> where TEntity : class, IEntity<TKey>
	{
		IEnumerable<TEntity> GetCollection(string key);
		TEntity Get(string key);
		void Set(TEntity entity, string key);
		void Set(TEntity entity, string key, TimeSpan timeSpan);
		void SetCollection(IEnumerable<TEntity> collection, string key);
		void SetCollection(IEnumerable<TEntity> collection, string key, TimeSpan timeSpan);
		void Delete(string key);
	}
}
