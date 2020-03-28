# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
### Added
- `Boolean()` function that returns a random boolean
- OpenUPM version banner added to README.md 

## [1.0.0] - 2020-03-27
### Added
- standard Unity3d folder hierarchy (`/Assets`, `/ProjectSettings`, `/Packages` etc)
- license to section that will appear in packaged versions of the repository
- commonly local-copy-only Unity3d files to ignore list
- Assembly Definition file (.asmdef) as 'PcgRandom'

### Changed
- moved Pcg.cs to `Assets/PcgRandom` directory for package use
- removed trailing 'L' from unsigned-long integer definitions that caused compile errors
- exposed m_state and m_inc as protected members for inherited manipulation