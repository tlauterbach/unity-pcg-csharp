using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Assertions;

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

			/* Should always be in this order after the shuffle *
			 * -29, 3, -2, 199, 55, 8, 0, 1, 39, 1290           */

			Assert.AreEqual(-29, list[0]);
			Assert.AreEqual(3,   list[1]);
			Assert.AreEqual(-2,  list[2]);
			Assert.AreEqual(199, list[3]);
			Assert.AreEqual(55,  list[4]);
			Assert.AreEqual(8,   list[5]);
			Assert.AreEqual(0,   list[6]);
			Assert.AreEqual(1,   list[7]);
			Assert.AreEqual(39,  list[8]);
			Assert.AreEqual(1290,list[9]);
		}

	}

}
 