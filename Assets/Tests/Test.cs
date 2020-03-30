using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace PcgRandom {

	public sealed class Test : MonoBehaviour {

		private void Awake() {
			List<int> list = new List<int>() {
				8, 3, -2, 39, 1290, 199, -29, 55, 1, 0
			};
			Pcg randomizer = new Pcg();
			list.Shuffle(randomizer);
			StringBuilder builder = new StringBuilder();
			builder.Append("Output:");
			foreach (int item in list) {
				builder.Append('\n').Append(item.ToString());
			}
			Debug.Log(builder.ToString());
		}

	}

}