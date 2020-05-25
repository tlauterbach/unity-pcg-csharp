# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
### Added
- missing license header in `Extensions.cs`
- `InvalidOperationException` to extension methods when given collection has no elements or a length of zero
- `ArgumentNullException` to extension methods when the given `Pcg` argument is null
- Asserts in `Test.cs` Awake function to ensure that the `Shuffle` extension produces consistent results
- expanding documentation within `README.md`
- `.editorconfig` file to enforce tab size 4 in `*.cs` files

### Changed
- swapped `List<T>` in Extension methods in favor of interface version `IList<T>`

## [1.1.0] - 2020-03-30
### Added
- `Boolean` function to `Pcg` class that returns a random boolean
- OpenUPM version banner added to `README.md` 
- collection extension functions: `Shuffle`, `Choose`, `Take`
- test scene and `Test.cs` script (repository only)

### Changed
- reorganized code files into `Scripts` directory

## [1.0.0] - 2020-03-27
### Added
- standard Unity3d folder hierarchy (`Assets`, `ProjectSettings`, `Packages`, etc)
- license to section that will appear in packaged versions of the repository
- commonly local-copy-only Unity3d files to ignore list
- Assembly Definition file (.asmdef) as `PcgRandom`

### Changed
- moved `Pcg.cs` to `Assets/PcgRandom` directory for package use
- removed trailing 'L' from unsigned-long integer definitions that caused compile errors
- exposed `m_state` and `m_inc` as protected members for inherited manipulation