using System;
using System.Collections.Generic;
using RevStackCore.Pattern;
namespace RevStackCore.Cache
{
	public class EntityCollection<TEntity> : IEntity<string>
	{
		public string Id { get; set; }
		public IEnumerable<TEntity> Collection { get; set; }
	}
}
