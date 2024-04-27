// SPDX-License-Identifier: Apache-2.0
// © 2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;

namespace Depra.Impact.Surface
{
	public sealed class CustomImpactSurface : ImpactSurface
	{
		[SerializeField] private string _name;

		public override string Name() => _name;
	}
}