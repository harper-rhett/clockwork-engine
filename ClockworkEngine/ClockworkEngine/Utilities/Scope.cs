using System;

namespace Clockwork.Utilities;

public class Scope : IDisposable
{
	private Action scopeExited;

	public Scope(Action scopeEntered, Action scopeExited)
	{
		this.scopeExited = scopeExited;
		scopeEntered.Invoke();
	}

	public void Dispose()
	{
		scopeExited.Invoke();
	}
}
