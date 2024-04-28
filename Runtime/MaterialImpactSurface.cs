// SPDX-License-Identifier: Apache-2.0
// © 2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;

namespace Depra.Impact.Surface
{
	[RequireComponent(typeof(Renderer))]
	public sealed class MaterialImpactSurface : ImpactSurface
	{
		private Renderer _renderer;

		private void OnEnable() => _renderer = GetComponent<Renderer>();

		public override string Name() => _renderer.sharedMaterial.name;
	}
}