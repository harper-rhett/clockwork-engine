using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Clockwork.Utilities;

public static class CollectionExtensions
{
	public static List<int> GetIndices(this IList list)
	{
		return Enumerable.Range(0, list.Count).ToList();
	}
}
