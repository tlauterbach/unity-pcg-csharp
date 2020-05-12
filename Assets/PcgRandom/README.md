# unity-pcg-csharp
[![openupm](https://img.shields.io/npm/v/com.potatointeractive.pcg?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.potatointeractive.pcg/)

A C# version of the [PCG random number generator](http://www.pcg-random.org/). Currently implements the [Minimal C Edition](https://github.com/imneme/pcg-c-basic) with the addition of a non-zero bounded range.

| Package Name | Package Version | Unity Version |
|-----|-----|-----|
| com.potatointeractive.pcg | 1.2.0 | 2018.3 or newer |

## Extensions

### Shuffle
```csharp
namespace PcgRandom {
	public static Extensions {
		public static void Pcg.Shuffle<T>(this T[] array, Pcg randomizer);
		public static void Pcg.Shuffle<T>(this IList<T> list, Pcg randomizer);
	}
}
```
The `Shuffle` extension function lets you randomize the order of the elements within an `IList<T>` or `Array` instance using the given `Pcg` instance. 

#### Exceptions
- **ArgumentNullException** : thrown if the given `Pcg` instance is `null`, as it is required to execute the `Shuffle` behaviour.  

#### Usage Example
```csharp
// The  parameterless Pcg constructor uses a constant, default seed
// We are using it show that Shuffle produces a consistent result
Pcg randomizer = new Pcg(); 
List<int> list = new List<int>() {
	8, 3, -2, 39, 1290, 199, -29, 55, 1, 0
};
Debug.LogFormat(list[0], "`{0}'"); // prints `8'

list.Shuffle(randomizer);

Debug.LogFormat(list[0], "`{0}'"); // prints `-29'

// elements shuffled to be in this order: 
// -29, 3, -2, 199, 55, 8, 0, 1, 39, 1290
```

