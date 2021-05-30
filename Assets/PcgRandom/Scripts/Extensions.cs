/*
 * PCG Random Number Generation for C#.
 *
 * Copyright 2020 Terra Lauterbach <potatointeractive@gmail.com>
 * Copyright 2015 Kevin Harris <kevin@studiotectorum.com>
 * Copyright 2014 Melissa O'Neill <oneill@pcg-random.org>
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * For additional information about the PCG random number generation scheme,
 * including its license and other licensing options, visit
 *
 *     http://www.pcg-random.org
 */
using System;
using System.Collections.Generic;

namespace PcgRandom {

	public static class Extensions {

		public static void Shuffle<T>(this IList<T> list, Pcg randomizer) {
			if (randomizer == null) {
				throw new ArgumentNullException(nameof(randomizer));
			}
			int n = list.Count;
			while (n > 0) {
				int rand = Convert.ToInt32(randomizer.Range32(Convert.ToUInt32(n--)));
				T item = list[rand];
				list[rand] = list[n];
				list[n] = item;
			}
		}
		public static void Shuffle<T>(this T[] array, Pcg randomizer) {
			if (randomizer == null) {
				throw new ArgumentNullException(nameof(randomizer));
			}
			int n = array.Length;
			while (n > 0) {
				int rand = Convert.ToInt32(randomizer.Range32(Convert.ToUInt32(n--)));
				T item = array[rand];
				array[rand] = array[n];
				array[n] = item;
			}
		}
		
		public static T Choose<T>(this IList<T> list, Pcg randomizer) {
			if (randomizer == null) {
				throw new ArgumentNullException(nameof(randomizer));
			}
			if (list.Count == 0) {
				throw new InvalidOperationException("Given IList contains no elements, so no element can be returned.");
			}
			return list[Convert.ToInt32(randomizer.Range32(Convert.ToUInt32(list.Count)))];
		}
		public static T Choose<T>(this T[] array, Pcg randomizer) {
			if (randomizer == null) {
				throw new ArgumentNullException(nameof(randomizer));
			}
			if (array.Length == 0) {
				throw new InvalidOperationException("Given Array has a length of zero, so no element can be returned.");
			}
			return array[Convert.ToInt32(randomizer.Range32(Convert.ToUInt32(array.Length)))];
		}
		public static T Take<T>(this IList<T> list, Pcg randomizer) {
			if (randomizer == null) {
				throw new ArgumentNullException(nameof(randomizer));
			}
			if (list.Count == 0) {
				throw new InvalidOperationException("Given IList contains no elements, so no element can be returned.");
			}
			T item = Choose(list, randomizer);
			list.Remove(item);
			return item;
		}

	}

}

