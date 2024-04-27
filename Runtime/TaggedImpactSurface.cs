// SPDX-License-Identifier: Apache-2.0
// © 2024 Nikolay Melnikov <n.melnikov@depra.org>

namespace Depra.Impact.Surface
{
	public sealed class TaggedImpactSurface : ImpactSurface
	{
		public override string Name() => gameObject.tag;
	}
}