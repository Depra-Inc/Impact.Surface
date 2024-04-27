// SPDX-License-Identifier: Apache-2.0
// © 2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;

namespace Depra.Impact.Surface
{
	[DisallowMultipleComponent]
	public abstract class ImpactSurface : MonoBehaviour, IImpactSurface
	{
		public static readonly IImpactSurface DEFAULT = new DefaultSurface();

		public abstract string Name();

		private sealed class DefaultSurface : IImpactSurface
		{
			string IImpactSurface.Name() => "Default";
		}
	}
}