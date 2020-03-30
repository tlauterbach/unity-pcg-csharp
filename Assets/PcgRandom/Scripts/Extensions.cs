using System;
using System.Collections.Generic;

namespace PcgRandom {

	public static class Extensions {

		public static void Shuffle<T>(this List<T> list, Pcg randomizer) {
			int n = list.Count;
			while (n > 0) {
				int rand = Convert.ToInt32(randomizer.Range32(Convert.ToUInt32(n--)));
				T item = list[rand];
				list[rand] = list[n];
				list[n] = item;
			}
		}
		public static void Shuffle<T>(this T[] array, Pcg randomizer) {
			int n = array.Length;
			while (n > 0) {
				int rand = Convert.ToInt32(randomizer.Range32(Convert.ToUInt32(n--)));
				T item = array[rand];
				array[rand] = array[n];
				array[n] = item;
			}
		}
		
		public static T Choose<T>(this List<T> list, Pcg randomizer) {
			return list[Convert.ToInt32(randomizer.Range32(Convert.ToUInt32(list.Count)))];
		}
		public static T Choose<T>(this T[] array, Pcg randomizer) {
			return array[Convert.ToInt32(randomizer.Range32(Convert.ToUInt32(array.Length)))];
		}
		public static T Take<T>(this List<T> list, Pcg randomizer) {
			T item = Choose(list, randomizer);
			list.Remove(item);
			return item;
		}

	}

}

